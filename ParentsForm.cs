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
        private DataTable dataTable;
        public ParentsForm(Student _student)
        {
            InitializeComponent();
            student = _student;
            DisplayData();
            studentNameLabel.Text = $"Õppur nimi: {student.Name}";
        }

        private void DisplayData()
        {
            var dataService = new DataService();
            dataTable = new DataTable();
            adapter = dataService.GetParentsByStudent(student.Id);
            adapter.Fill(dataTable);
            parentsDataGridView.DataSource = dataTable;
        }

        private void dataPermissionCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            parentsDataGridView.Enabled = !dataPermissionCheckBox.Checked;
        }
    }
}
