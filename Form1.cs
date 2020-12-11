using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace tthk_contacts
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\AppData\contacts.mdf; Integrated Security = True");
        private SqlCommand command;
        private SqlDataAdapter adapter;

        private int id = 0;
        public Form1()
        {
            InitializeComponent();
            RequestGroups();
            DisplayData();
        }

        private void DisplayData()
        {
            connection.Open();
            DataTable table = new DataTable();
            adapter = SearchData();
            adapter.Fill(table);
            contactsDataGridView.DataSource = table;
            connection.Close();
        }

        private SqlDataAdapter SearchData()
        {
            return new SqlDataAdapter("SELECT * FROM Contacts;", connection);
        }

        private SqlDataAdapter SearchDataByGroup(int groupId)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Contacts WHERE groupId = @groupId;", connection);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@groupId", groupId);
            return dataAdapter;
        }

        private SqlDataAdapter SearchDataByName(string searchName)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Contacts WHERE name = @name;", connection);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@name", searchName);
            return dataAdapter;
        }

        private void RequestGroups()
        {
            connection.Open();
            command = new SqlCommand("SELECT Code FROM Groups;", connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    AddGroupToCombobox(reader, "Code");
                }
            }

            connection.Close();
        }

        private void AddGroupToCombobox(SqlDataReader source, string name)
        {
            groupComboBox.Items.Add(source[name].ToString());
        }

    }
}
