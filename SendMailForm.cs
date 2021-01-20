﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Crypto;

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
                var emailsList = emails.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                emailsList.ForEach(e => e.Trim());
                return emailsList;
            }

            return new List<string> { emails.Trim() };
        }

        private void wholeContactsButton_Click(object sender, EventArgs e)
        {
            DataService dataService = new DataService();
            recepientTextBox.Text = dataService.GetAllStudentsEmails();
        }

        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            Message message = new Message
            {
                Recipients = DivideEmailAddresses(recepientTextBox.Text),
                Subject = subjectTextBox.Text,
                Body = contentTextBox.Text
            };
            if (addScholarshipFileCheckbox.Checked)
            {
                message.Attachment = new Attachment(@"AppData\Eritoetuse avaldus.pdf");
            }
            message.Send();
            Close();
        }
    }
}
