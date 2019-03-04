using Microsoft.AspNetCore.Mvc;
using DummyCheckService.Service;
using System.Net.Mail;
using System.IO;
using System.Reflection;
using ClickNCheck.Models;
using ClickNCheck.Services;
using System;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DummyCheckService.Controllers
{
    [Route("mail")]
    [ApiController]
    public class LongRunningMail : Controller
    {
        // GET api/values
        [HttpGet]
        public ActionResult GetResults()
        {
            User user = new User();
            user.ID = "test";
            user.Title = "test";
            user.Name = "test";
            user.Surname = "test";
            user.DOB = "test";
            user.Gender = "test";
            user.Address = "test";
            DateTime foo = DateTime.UtcNow;
            user.Time =  foo.ToString();
            user.Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis ultrices feugiat tempor. Donec erat justo, condimentum vitae molestie vitae, blandit sed tortor. Maecenas dui risus, tristique dictum finibus nec, maximus elementum risus. Sed fermentum ornare sagittis. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Sed dictum ante sapien, nec luctus magna malesuada vitae.";
            user.Status = "Passed";
            PDFGenerator.GeneratePDF(user);
            EmailService service = new EmailService();
            var mailBody = service.RecruiterMail();
            mailBody = mailBody.Replace("{id}", user.ID);
            mailBody = mailBody.Replace("{title}", user.Title);
            mailBody = mailBody.Replace("{name}", user.Name);
            mailBody = mailBody.Replace("{surname", user.Surname);
            mailBody = mailBody.Replace("{dob}", user.DOB);
            mailBody = mailBody.Replace("{gender}", user.Gender);
            mailBody = mailBody.Replace("{address}", user.Address);
            mailBody = mailBody.Replace("{time}", user.Time);
            mailBody = mailBody.Replace("{description}", user.Description);
            mailBody = mailBody.Replace("{status}", user.Status);
            Attachment attachment = new Attachment(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Files\results.pdf"));
            Attachment[] attachments = {attachment,attachment};
            System.Threading.Thread.Sleep(120000);
            service.SendMail("vurayayid@gmail.com", "DummyCheckService Results", mailBody, attachments);

            return Ok("Email Sent");
        }
    }
}
