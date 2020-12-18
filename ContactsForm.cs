using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using tthk_contacts.Models;

namespace tthk_contacts
{
    public partial class ContactsForm : Form
    {
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private int id = 0;
        private Contact currentContact;
        public ContactsForm()
        {
            InitializeComponent();
            RequestGroups();
            DisplayData();
        }

        private void DisplayData()
        {
            DataService dataService = new DataService();
            DataTable table = new DataTable();
            adapter = dataService.SearchData();
            adapter.Fill(table);
            contactsDataGridView.DataSource = table;
        }

        private void DisplayData(string searchName)
        {
            DataService dataService = new DataService();
            DataTable table = new DataTable();
            adapter = dataService.SearchData(searchName);
            adapter.Fill(table);
            contactsDataGridView.DataSource = table;
        }

        private void DisplayData(int groupId)
        {
            DataService dataService = new DataService();
            DataTable table = new DataTable();
            adapter = dataService.SearchData(groupId);
            adapter.Fill(table);
            contactsDataGridView.DataSource = table;
        }

        private void DisplayData(string searchName, int groupId)
        {
            DataService dataService = new DataService();
            DataTable table = new DataTable();
            adapter = dataService.SearchData(searchName, groupId);
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
                contactPictureBox.Image = new Bitmap(picture);
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
            contactComboBox.SelectedIndex = 0;
        }

        private void RequestGroups()
        {
            DataService dataService = new DataService();
            groupComboBox.Items.Add("Kõik");
            contactComboBox.Items.Add("Pole");
            foreach (string group in dataService.SearchGroups())
            {
                groupComboBox.Items.Add(group);
                contactComboBox.Items.Add(group);
            }
        }

        private void groupComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            SelectedGroupData();
        }

        private void SelectedGroupData()
        {
            
            if (SelectedGroup <= 0)
            {
                DisplayData();
            }
            else
            {
                DisplayData(SelectedGroup);
            }
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
        }

        private int SelectedGroup => groupComboBox.SelectedIndex;

        private void contactPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images (*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                pictureTextBox.Text = fileName;
                DisplayContactPicture(fileName);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text;
            if (ValidateTextBox(searchTextBox))
            {
                if (SelectedGroup <= 0)
                {
                    DisplayData(searchText);
                    
                }
                else
                {
                    DisplayData(searchText, SelectedGroup);
                }
            }
            else
            {
                DisplayData();
            }
        }

        private bool ValidateTextBox(TextBox textBox)
        {
            DataService dataService = new DataService();
            return dataService.ValidateText(textBox.Text);
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            if (ValidateTextBox(nameTextBox))
            {
                currentContact = new Contact()
                {
                    Name = nameTextBox.Text,
                    Phone = phoneTextBox.Text,
                    Email = emailTextBox.Text,
                    PicturePath = pictureTextBox.Text,
                    GroupId = groupComboBox.SelectedIndex
                };
                DataService dataService = new DataService();
                dataService.AddContact(currentContact);
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
                if (ValidateTextBox(pictureTextBox))
                {
                    DisplayContactPicture(pictureTextBox.Text);
                }    
            }
            catch (Exception exception)
            {

            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (groupComboBox.SelectedIndex > 0)
            {
                groupComboBox.SelectedIndex--;
            }
            
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (groupComboBox.SelectedIndex < groupComboBox.Items.Count-1)
            {
                groupComboBox.SelectedIndex++;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (ValidateTextBox(nameTextBox) && id != 0)
            {
                currentContact = new Contact()
                {
                    Id = id,
                    Name = nameTextBox.Text,
                    Phone = phoneTextBox.Text,
                    Email = emailTextBox.Text,
                    PicturePath = pictureTextBox.Text,
                    GroupId = contactComboBox.SelectedIndex
                };
                DataService dataService = new DataService();
                dataService.UpdateContact(currentContact);
                SelectedGroupData();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                DataService dataService = new DataService();
                dataService.DeleteContact(id);
                ClearData();
                SelectedGroupData();
            }
        }
    }
}
