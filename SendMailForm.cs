using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
using Message = tthk_contacts.Models.Message;

namespace tthk_contacts
{
    public partial class SendMailForm : Form
    {
        string addedFile;
        public SendMailForm(string recepientEmail)
        {
            InitializeComponent();
            recepientTextBox.Text = recepientEmail;
        }

        public List<string> DivideEmailAddresses(string emails)
        {
            if (emails.Contains(';'))
            {
                var emailsList = emails.Split(new[] {';'}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                emailsList.ForEach(e => e.Trim());
                return emailsList;
            }

            return new List<string> {emails.Trim()};
        }

        private void wholeContactsButton_Click(object sender, EventArgs e)
        {
            var dataService = new DataService();
            recepientTextBox.Text = dataService.GetAllStudentsEmails();
        }

        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            var message = new Message
            {
                Recipients = DivideEmailAddresses(recepientTextBox.Text),
                Subject = subjectTextBox.Text,
                Body = contentTextBox.Text
            };
            if (addScholarshipFileCheckbox.Checked)
                message.Attachments[0] = new Attachment(@"AppData\Eritoetuse avaldus.pdf");
            if (addLunchScholarshipCheckBox.Checked)
                message.Attachments[1] = new Attachment(@"AppData\Lõunatoetuse avaldus.pdf");
            if (!String.IsNullOrEmpty(addedFile))
                message.Attachments[2] = new Attachment(addedFile);
            message.Send();
            Close();
        }

        private void addFileButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog.FileName;
                addedFile = filePath;
            }
        }
    }
}