using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using tthk_contacts.Models;

namespace tthk_contacts
{
    public partial class ContactsForm : Form
    {
        private SqlDataAdapter adapter;
        private Student currentStudent;
        private int id;

        public ContactsForm()
        {
            InitializeComponent();
            RequestGroups();
            DisplayData();
        }

        private int SelectedGroup => groupComboBox.SelectedIndex;
        private bool ShowInactives => showInactivesCheckbox.Checked;

        private void DisplayData()
        {
            var dataService = new DataService();
            var table = new DataTable();
            adapter = dataService.GetStudents(ShowInactives);
            adapter.Fill(table);
            contactsDataGridView.DataSource = table;
        }

        private void DisplayData(string searchName)
        {
            var dataService = new DataService();
            var table = new DataTable();
            adapter = dataService.GetStudents(searchName, ShowInactives);
            adapter.Fill(table);
            contactsDataGridView.DataSource = table;
        }

        private void DisplayData(int groupId)
        {
            var dataService = new DataService();
            var table = new DataTable();
            adapter = dataService.GetStudents(groupId, ShowInactives);
            adapter.Fill(table);
            contactsDataGridView.DataSource = table;
        }

        private void DisplayData(string searchName, int groupId)
        {
            var dataService = new DataService();
            var table = new DataTable();
            adapter = dataService.GetStudents(searchName, groupId, ShowInactives);
            adapter.Fill(table);
            contactsDataGridView.DataSource = table;
        }

        private void DisplayContactPicture(string picture)
        {
            if (picture.StartsWith("http"))
            {
                contactPictureBox.Load(picture);
            }
            else
            {
                try
                {
                    contactPictureBox.Image = new Bitmap(picture);
                }
                catch (Exception)
                {
                    contactPictureBox.Image = null;
                }
            }
                
        }

        private void ClearData()
        {
            id = 0;
            nameTextBox.Text = "";
            emailTextBox.Text = "";
            phoneTextBox.Text = "";
            contactPictureBox.Image = null;
            pictureTextBox.Text = "";
            scholarshipCheckbox.Checked = false;
            contactGroupComboBox.SelectedIndex = 0;
            dateOfBirthPicker.Value = DateTime.Now;
            activeCheckbox.Checked = true;
        }

        private void ClearGroups()
        {
            groupComboBox.Items.Clear();
            contactGroupComboBox.Items.Clear();
        }

        private void RequestGroups()
        {
            ClearGroups();
            var dataService = new DataService();
            groupComboBox.Items.Add("Kõik");
            contactGroupComboBox.Items.Add("Pole");
            foreach (var group in dataService.GetGroups())
            {
                groupComboBox.Items.Add(group);
                contactGroupComboBox.Items.Add(group);
            }
        }

        private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedGroupData();
        }

        private void SelectedGroupData()
        {
            if (SelectedGroup <= 0)
                DisplayData();
            else
                DisplayData(SelectedGroup);
            ClearData();
        }

        private void UpdateData()
        {
            var searchText = searchTextBox.Text;
            if (ValidateTextBox(searchTextBox))
            {
                if (SelectedGroup <= 0)
                    DisplayData(searchText);
                else
                    DisplayData(searchText, SelectedGroup);
            }
            else
            {
                DisplayData();
            }
        }

        private void SelectedContactDataFromTable(int row)
        {
            currentStudent = new Student
            {
                Id = Convert.ToInt32(contactsDataGridView.Rows[row].Cells[0].Value.ToString()),
                Name = contactsDataGridView.Rows[row].Cells[1].Value.ToString(),
                Phone = contactsDataGridView.Rows[row].Cells[2].Value.ToString(),
                Email = contactsDataGridView.Rows[row].Cells[3].Value.ToString(),
                PicturePath = contactsDataGridView.Rows[row].Cells[4].Value.ToString(),
                GroupId = Convert.ToInt32(contactsDataGridView.Rows[row].Cells[5].Value.ToString()),
                Scholarship = Convert.ToBoolean(contactsDataGridView.Rows[row].Cells[6].Value),
                DateOfBirth = Convert.ToDateTime(contactsDataGridView.Rows[row].Cells[7].Value),
                Active = Convert.ToBoolean(contactsDataGridView.Rows[row].Cells[8].Value),
                DataPermission = Convert.ToBoolean(contactsDataGridView.Rows[row].Cells[9].Value)
            };
        }

        private void FillFields(Student student)
        {
            id = student.Id;
            nameTextBox.Text = student.Name;
            phoneTextBox.Text = student.Phone;
            emailTextBox.Text = student.Email;
            DisplayContactPicture(student.PicturePath);
            pictureTextBox.Text = student.PicturePath;
            contactGroupComboBox.SelectedIndex = student.GroupId;
            scholarshipCheckbox.Checked = student.Scholarship;
            dateOfBirthPicker.Value = student.DateOfBirth;
            activeCheckbox.Checked = student.Active;
        }

        private void contactPictureBox_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Images (*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                pictureTextBox.Text = fileName;
                DisplayContactPicture(fileName);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private bool ValidateTextBox(TextBox textBox)
        {
            return !string.IsNullOrEmpty(textBox.Text);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ValidateTextBox(nameTextBox) &&
                ValidateTextBox(phoneTextBox) &&
                ValidateTextBox(emailTextBox))
            {
                currentStudent = new Student
                {
                    Name = nameTextBox.Text,
                    Phone = phoneTextBox.Text,
                    Email = emailTextBox.Text,
                    PicturePath = pictureTextBox.Text,
                    Scholarship = scholarshipCheckbox.Checked,
                    GroupId = contactGroupComboBox.SelectedIndex,
                    DateOfBirth = dateOfBirthPicker.Value,
                    Active = activeCheckbox.Checked,
                    DataPermission = true
                };
                var dataService = new DataService();
                dataService.AddStudent(currentStudent);
                SelectedGroupData();
                ClearData();
            }
        }

        private void ContactsDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                SelectedContactDataFromTable(e.RowIndex);
                FillFields(currentStudent);
            }
            catch (FormatException)
            {
                MessageBox.Show("Valitud rida on tühi.");
                ClearData();
            }
        }

        private void AddPictureLinkButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateTextBox(pictureTextBox)) DisplayContactPicture(pictureTextBox.Text);
            }
            catch (Exception)
            {
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (groupComboBox.SelectedIndex > 0) groupComboBox.SelectedIndex--;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (groupComboBox.SelectedIndex < groupComboBox.Items.Count - 1) groupComboBox.SelectedIndex++;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (ValidateTextBox(nameTextBox) && id != 0)
            {
                currentStudent = new Student
                {
                    Id = id,
                    Name = nameTextBox.Text,
                    Phone = phoneTextBox.Text,
                    Email = emailTextBox.Text,
                    PicturePath = pictureTextBox.Text,
                    Scholarship = scholarshipCheckbox.Checked,
                    GroupId = contactGroupComboBox.SelectedIndex,
                    DateOfBirth = dateOfBirthPicker.Value,
                    Active = activeCheckbox.Checked
                };
                var dataService = new DataService();
                dataService.Update(currentStudent);
                SelectedGroupData();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                var dataService = new DataService();
                dataService.DeleteStudent(id);
                ClearData();
                SelectedGroupData();
            }
        }

        private void ClearFieldsButton_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            var sendMailForm = new SendMailForm(emailTextBox.Text);
            sendMailForm.Show();
        }

        private void AddGroupButton_Click(object sender, EventArgs e)
        {
            if (ValidateTextBox(newGroupCodeTextBox))
            {
                var newGroupCode = newGroupCodeTextBox.Text.Trim();
                if (!groupComboBox.Items.Contains(newGroupCode))
                {
                    var dataService = new DataService();
                    dataService.AddGroup(newGroupCode);
                    RequestGroups();
                }
            }
        }

        private void DeleteGroupButton_Click(object sender, EventArgs e)
        {
            if (groupComboBox.SelectedIndex > 0)
            {
                var dataService = new DataService();
                dataService.ClearStudentsGroup(groupComboBox.SelectedIndex);
                dataService.DeleteGroup(groupComboBox.SelectedIndex);
                groupComboBox.SelectedIndex = 0;
                RequestGroups();
            }
        }

        private void parentsButton_Click(object sender, EventArgs e)
        {
            if (currentStudent == null) return;
            var parentsForm = new ParentsForm(currentStudent);
            parentsForm.Show();
            parentsForm.Focus();
        }

        private void showInactivesCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateData();
        }
    }
}