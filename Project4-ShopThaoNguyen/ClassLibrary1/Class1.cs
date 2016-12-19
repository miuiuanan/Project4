using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Configuration;

namespace ClassLibrary1
{
    public class Class1
    {
        public void SendMail(string ToEmail, string subject, string content)
        {
            var fromEmailAddress = "nguyenthaohuonghy@gmail.com";
            var fromEmailDisplayName = "Shop Thảo Nguyên";
            var fromEmailPassword = "thaohuong";
            var smtpHost = "smtp.gmail.com";
            var smtpPort = 587;
            bool enabledSSL = true;

            string body = content;
            MailMessage mess = new MailMessage(new MailAddress(fromEmailAddress, fromEmailDisplayName), new MailAddress(ToEmail));
            mess.Subject = subject;
            mess.IsBodyHtml = true;
            mess.Body = body;

            var client = new SmtpClient();
            client.Credentials = new NetworkCredential(fromEmailAddress, fromEmailPassword);
            client.Host = smtpHost;
            client.EnableSsl = enabledSSL;
            client.Port = smtpPort;
            client.Send(mess);
        }
    }
}
