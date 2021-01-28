using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace tthk_contacts.Models
{
    internal class Message
    {
        public const string Sender = "contacts@laus19.thkit.ee";
        public const string Password = "siinSaabTeavitadaKeegi";
        public List<string> Recipients { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public Attachment[] Attachments { get; set; }

        public void Send()
        {
            try
            {
                var mailMessage = new MailMessage();
                var smtpClient = new SmtpClient("smtp.zone.eu", 587)
                {
                    Credentials = new NetworkCredential(Sender, Password),
                    EnableSsl = true
                };
                mailMessage.From = new MailAddress(Sender, "Õppurite teavitamine");
                foreach (var recipent in Recipients) mailMessage.To.Add(recipent);
                mailMessage.Subject = Subject;
                mailMessage.Body = Body;
                if (Attachments != null)
                {
                    foreach (var attachment in Attachments)
                    {
                        mailMessage.Attachments.Add(attachment);
                    }
                }
                smtpClient.Send(mailMessage);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}