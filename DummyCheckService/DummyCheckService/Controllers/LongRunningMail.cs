using Microsoft.AspNetCore.Mvc;
using DummyCheckService.Services;
using System.Net.Mail;
using System.IO;
using System.Reflection;
using DummyCheckService.Models;
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
            user.ID = "8209147250087";
            user.Title = "Mr";
            user.Name = "John";
            user.Surname = "Doe";
            user.DOB = "14-09-1982";
            user.Gender = "Male";
            user.Address = "House 89919, Test Estate, Test street, Test Town, Test City, Test Province";
            DateTime foo = DateTime.UtcNow;
            user.Time =  foo.ToString();
            user.Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis ultrices feugiat tempor. Donec erat justo, condimentum vitae molestie vitae, blandit sed tortor. Maecenas dui risus, tristique dictum finibus nec, maximus elementum risus. Sed fermentum ornare sagittis. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Sed dictum ante sapien, nec luctus magna malesuada vitae.";
            user.Status = "Passed";
            
            EmailService service = new EmailService();
            var mailBody = service.RecruiterMail(user);
            Attachment attachment = new Attachment(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Files\results.pdf"));
            Attachment[] attachments = {attachment,attachment};
            service.SendMail("clickncheckservice@gmail.com", "DummyCheckService Results for: 59117966", mailBody, attachments);

            return Ok("Email Sent");
        }
    }
}
