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
        private SqlCommand command;
        private Student currentStudent;
        private int id;

        public ContactsForm()
        {
            InitializeComponent();
            RequestGroups();
            DisplayData();
        }

        private int SelectedGroup => groupComboBox.SelectedIndex;

        private void DisplayData()
        {
            var dataService = new DataService();
            var table = new DataTable();
            adapter = dataService.GetStudents();
            adapter.Fill(table);
            contactsDataGridView.DataSource = table;
        }

        private void DisplayData(string searchName)
        {
            var dataService = new DataService();
            var table = new DataTable();
            adapter = dataService.GetStudents(searchName);
            adapter.Fill(table);
            contactsDataGridView.DataSource = table;
        }

        private void DisplayData(int groupId)
        {
            var dataService = new DataService();
            var table = new DataTable();
            adapter = dataService.GetStudents(groupId);
            adapter.Fill(table);
            contactsDataGridView.DataSource = table;
        }

        private void DisplayData(string searchName, int groupId)
        {
            var dataService = new DataService();
            var table = new DataTable();
            adapter = dataService.GetStudents(searchName, groupId);
            adapter.Fill(table);
            contactsDataGridView.DataSource = table;
        }

        private void DisplayContactPicture(string picture)
        {
            if (picture.StartsWith("http"))
                contactPictureBox.Load(picture);
            else
                contactPictureBox.Image = new Bitmap(picture);
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
            contactComboBox.SelectedIndex = 0;
        }

        private void ClearGroups()
        {
            groupComboBox.Items.Clear();
            contactComboBox.Items.Clear();
        }

        private void RequestGroups()
        {
            ClearGroups();
            var dataService = new DataService();
            groupComboBox.Items.Add("Kõik");
            contactComboBox.Items.Add("Pole");
            foreach (var group in dataService.GetGroups())
            {
                groupComboBox.Items.Add(group);
                contactComboBox.Items.Add(group);
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

        private void SelectedContactData(int row)
        {
            id = Convert.ToInt32(contactsDataGridView.Rows[row].Cells[0].Value.ToString());
            nameTextBox.Text = contactsDataGridView.Rows[row].Cells[1].Value.ToString();
            phoneTextBox.Text = contactsDataGridView.Rows[row].Cells[2].Value.ToString();
            emailTextBox.Text = contactsDataGridView.Rows[row].Cells[3].Value.ToString();
            DisplayContactPicture(contactsDataGridView.Rows[row].Cells[4].Value.ToString());
            pictureTextBox.Text = contactsDataGridView.Rows[row].Cells[4].Value.ToString();
            contactComboBox.SelectedIndex = Convert.ToInt32(contactsDataGridView.Rows[row].Cells[5].Value.ToString());
            scholarshipCheckbox.Checked = Convert.ToBoolean(contactsDataGridView.Rows[row].Cells[6].Value);
            dateOfBirthPicker.Value = Convert.ToDateTime(contactsDataGridView.Rows[row].Cells[7].Value);
        }

        private void contactPictureBox_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images (*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                pictureTextBox.Text = fileName;
                DisplayContactPicture(fileName);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
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

        private bool ValidateTextBox(TextBox textBox)
        {
            var dataService = new DataService();
            return dataService.ValidateText(textBox.Text);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ValidateTextBox(nameTextBox))
            {
                currentStudent = new Student
                {
                    Name = nameTextBox.Text,
                    Phone = phoneTextBox.Text,
                    Email = emailTextBox.Text,
                    PicturePath = pictureTextBox.Text,
                    Scholarship = scholarshipCheckbox.Checked,
                    GroupId = groupComboBox.SelectedIndex,
                    DateOfBirth = dateOfBirthPicker.Value
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
                SelectedContactData(e.RowIndex);
            }
            catch (FormatException exception)
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
            catch (Exception exception)
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
                    GroupId = contactComboBox.SelectedIndex
                };
                var dataService = new DataService();
                dataService.UpdateStudent(currentStudent);
                SelectedGroupData();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                var dataService = new DataService();
                dataService.DeleteContact(id);
                ClearData();
                SelectedGroupData();
            }
        }

        private void ClearFieldsButton_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ScholarshipCheckbox_CheckedChanged(object sender, EventArgs e)
        {
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
                string newGroupCode = newGroupCodeTextBox.Text.Trim();
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
                dataService.ClearStudentsGroup(groupComboBox.SelectedText);
                dataService.DeleteGroup(groupComboBox.SelectedText);
                RequestGroups();
            }
        }
    }
}