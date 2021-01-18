using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            return emails.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        private void wholeContactsButton_Click(object sender, EventArgs e)
        {

        }

        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            Message message = new Message
            {
                Recipients = DivideEmailAddresses(recepientTextBox.Text),
                Subject = subjectTextBox.Text,
                Body = contentTextBox.Text
            };
            message.Send();
        }
    }
}
