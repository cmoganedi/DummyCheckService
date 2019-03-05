using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Linq;
using System.Net.Mime;
using System.IO;
using System.Reflection;
using DummyCheckService.Models;

namespace DummyCheckService.Services
{
    public class EmailService
    {
        readonly string smtpAddress = "smtp.gmail.com";
        readonly int portNumber = 587;
        readonly bool enableSSL = true;
        readonly string emailFromAddress = "dummycheckservice@gmail.com";//"dlaminixolani440@gmail.com"; //Sender Email Address
        readonly string password = "TesterEm@il";//"159357OLANI"; //Sender Password


        public bool SendMail(string to, string subject, string body, Attachment[] attachments)
        {
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    MailAssignment(mail, emailFromAddress, to, subject, body, attachments);
                    SmtpSend(mail);
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        private void MailAssignment(MailMessage mail, string from, string to, string subject, string body, Attachment[] attachments)
        {
            mail.From = new MailAddress(from);
            mail.To.Add(to);
            mail.Subject = subject;
            mail.IsBodyHtml = true;
            mail.Body = body;
            for (int i = 0; i < attachments.Length; i++)
            {
                mail.Attachments.Add(attachments[i]);
            }
        }

        private void SmtpSend(MailMessage mail)
        {
            SmtpClient smtp = new SmtpClient(smtpAddress, portNumber)
            {
                Credentials = new NetworkCredential(emailFromAddress, password),
                EnableSsl = enableSSL
            };
            smtp.Send(mail);
        }

        public string RecruiterMail(User user)
        {
            string mailBody = System.IO.File.ReadAllText(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Files\RecruiterMail.html"));
            mailBody = replaceBody(user, mailBody);
            //PDFGenerator.GeneratePDF(user,mailBody);
            return mailBody;
        }

        public static string replaceBody(User user, string body)
        {
            body = body.Replace("{id}", user.ID);
            body = body.Replace("{title}", user.Title);
            body = body.Replace("{name}", user.Name);
            body = body.Replace("{surname", user.Surname);
            body = body.Replace("{dob}", user.DOB);
            body = body.Replace("{gender}", user.Gender);
            body = body.Replace("{address}", user.Address);
            body = body.Replace("{time}", user.Time);
            body = body.Replace("{description}", user.Description);
            body = body.Replace("{status}", user.Status);
            return body;
        }
    }
}
