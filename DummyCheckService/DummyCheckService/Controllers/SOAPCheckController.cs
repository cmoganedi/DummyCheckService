using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DummyCheckService.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DummyCheckService.Controllers
{
    [Route("api/[controller]")]
    public class SOAPCheckController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public string Get()
        {
            return "ping - responded";
        }
        // POST api/<controller>
        [HttpPost]
        public string Post(string value)
        {
            return "Specify the vendor in the route!";
        }

        // POST api/<controller>/compuscan
        [HttpPost]
        [Route("Compuscan")]
        public string Compuscan(string value)
        {
            SOAPService soapObject = new SOAPService();
            //string soap = soapObject.RompuscanResponse();

            return soapObject.RompuscanResponse();

        }
        // POST api/<controller>/therest
        [HttpPost]
        [Route("TheRest")]
        public string therest([FromBody]string value)
        {
            SOAPService soapObject = new SOAPService();
            string soap = soapObject.TherestResponse();

            return soap;
        }
    }
}
