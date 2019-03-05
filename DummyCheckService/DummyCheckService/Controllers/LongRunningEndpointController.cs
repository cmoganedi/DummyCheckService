using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DummyCheckService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LongRunningEndpointController : ControllerBase
    {
        public enum checkStatus { Active, Failed, PossibleIssues, Cleared, InProgress, NotStarted}

        // POST: api/available/addService
        [HttpPost]
        [Route("theEndpoint")]
        public ActionResult theEndpoint()
        {

            byte[] file = System.IO.File.ReadAllBytes(@"C:\Users\Mpinane Mohale\Downloads\32423.pdf");

            dynamic result = new Newtonsoft.Json.Linq.JObject();
            result.checkId = 1;
            result.resultStatus = checkStatus.Cleared.ToString();
            result.resultDesciption = "Check came back with no issues";
            result.file = Convert.ToBase64String(file);


            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("https://localhost:44347/LongRunningENdpoint");
            webRequest.ContentType = "application/json";
            webRequest.Method = "POST";
            webRequest.KeepAlive = true;

            //ASCIIEncoding encoding = new ASCIIEncoding();
            //byte[] body = System.IO.GetBytes(result);

            //webRequest.ContentLength = result.Length;

            byte[] body = Encoding.UTF8.GetBytes(result.ToString());
            Stream newStream = webRequest.GetRequestStream();
            webRequest.Accept = "application/json";
            webRequest.ContentLength = body.Length;
            newStream.Write(body, 0, body.Length);
            newStream.Close();
           // webRequest.GetResponse();

            return Ok(webRequest.GetResponse()); 
        }
    }
}