using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using tthk_contacts.Models;

namespace tthk_contacts
{
    public partial class ParentsForm : Form
    {
        private Student student;
        private SqlDataAdapter adapter;
        private Parent currentParent;
        private int id;

        public ParentsForm(Student _student)
        {
            InitializeComponent();
            student = _student;
            dataPermissionCheckBox.Checked = student.DataPermission;
            DisplayData();
            studentNameLabel.Text = $"Õppur nimi: {student.Name}";
        }

        private void DisplayData()
        {
            var dataService = new DataService();
            var table = new DataTable();
            adapter = dataService.GetParentsByStudent(student.Id);
            if (dataPermissionCheckBox.Checked)
            {
                adapter.Fill(table);
            }
            parentsDataGridView.DataSource = table;
        }

        private void dataPermissionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DisplayData();
            DataService dataService = new DataService();
            student.DataPermission = dataPermissionCheckBox.Checked;
            dataService.ChangeDataPermission(student);
        }

        private void SelectedParentDataFromTable(int row)
        {
            try
            {
                currentParent = new Parent
                {
                    Id = Convert.ToInt32(parentsDataGridView.Rows[row].Cells[0].Value.ToString()),
                    Name = parentsDataGridView.Rows[row].Cells[1].Value.ToString(),
                    Phone = parentsDataGridView.Rows[row].Cells[2].Value.ToString(),
                    Email = parentsDataGridView.Rows[row].Cells[3].Value.ToString(),
                    Active = Convert.ToBoolean(parentsDataGridView.Rows[row].Cells[4].Value),
                    ChildrenId = Convert.ToInt32(parentsDataGridView.Rows[row].Cells[5].Value)
                };
            }
            catch (Exception)
            {
                MessageBox.Show("Valitud rida on tühi!");
            }
            
        }

        private bool ValidateTextBox(TextBox textBox)
        {
            return !string.IsNullOrEmpty(textBox.Text);
        }

        private void FillFields(Parent parent)
        {
            id = parent.Id;
            nameTextBox.Text = parent.Name;
            phoneTextBox.Text = parent.Phone;
            emailTextBox.Text = parent.Email;
            activeCheckBox.Checked = parent.Active;
        }

        private void ClearFields()
        {
            id = 0;
            nameTextBox.Text = "";
            phoneTextBox.Text = "";
            emailTextBox.Text = "";
            activeCheckBox.Checked = false;
        }

        private void parentsDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                SelectedParentDataFromTable(e.RowIndex);
                FillFields(currentParent);
            }
            catch (FormatException)
            {
                MessageBox.Show("Valitud rida on tühi.");
            }
        }

        private void addParentButton_Click(object sender, EventArgs e)
        {
            if (ValidateTextBox(nameTextBox) &&
                ValidateTextBox(phoneTextBox) &&
                ValidateTextBox(emailTextBox))
            {
                currentParent = new Parent
                {
                    Name = nameTextBox.Text,
                    Phone = phoneTextBox.Text,
                    Email = emailTextBox.Text,
                    Active = activeCheckBox.Checked,
                    ChildrenId = student.Id
                };
                var dataService = new DataService();
                dataService.AddParent(currentParent);
                DisplayData();
                ClearFields();
            }
        }

        private void changeParentButton_Click(object sender, EventArgs e)
        {
            if (ValidateTextBox(nameTextBox) && 
                ValidateTextBox(emailTextBox) && 
                ValidateTextBox(phoneTextBox) &&
                id != 0)
            {
                currentParent = new Parent
                {
                    Id = id,
                    Name = nameTextBox.Text,
                    Phone = phoneTextBox.Text,
                    Email = emailTextBox.Text,
                    Active = activeCheckBox.Checked,
                    ChildrenId = student.Id
                };
                var dataService = new DataService();
                dataService.Update(currentParent);
                DisplayData();
                ClearFields();
            }
        }

        private void deleteParentButton_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                var dataService = new DataService();
                dataService.DeleteParent(id);
                DisplayData();
                ClearFields();
            }
        }

        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            var sendMailForm = new SendMailForm(emailTextBox.Text);
            sendMailForm.Show();
        }
    }
}