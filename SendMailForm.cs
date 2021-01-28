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
                message.Attachment[0] = new Attachment(@"AppData\Eritoetuse avaldus.pdf");
            else
                message.Attachment[1] = null;
            if (addLunchscholarshipCheckBox.Checked)
                message.Attachment[1] = new Attachment(@"AppData\Koolilõunatoetuse avaldus.pdf");
            else
                message.Attachment[1] = null;
            message.Send();
            Close();
        }
    }
}