using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tthk_contacts
{
    class Mail
    {
        public const string Sender = "x";
        public const string Password = "x";
        public List<string> Recipients { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public Attachment Attachment { get; set; }

        public void SendMessage()
        {
            try
            {
                MailMessage mailMessage = new MailMessage();
                SmtpClient smtpClient = new SmtpClient()
                {
                    Port = 587,
                    Credentials = new System.Net.NetworkCredential(Sender, Password),
                    EnableSsl = true
                };
                mailMessage.From = new MailAddress(Sender);
                foreach (var recipent in Recipients)
                {
                    mailMessage.To.Add(recipent);
                }
                mailMessage.Subject = Subject;
                mailMessage.Body = Body;
                // mailMessage.Attachments.Add(Attachment);
                smtpClient.Send(mailMessage);
            }
            catch (Exception)
            {
                MessageBox.Show("Viga!");
            }
        }
    }
}
