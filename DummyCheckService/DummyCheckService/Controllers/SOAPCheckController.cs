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
            SOAPService soapObject = new SOAPService(value);
            string cridentialsRequired = soapObject.getCredentials();
            return soapObject.RompuscanResponse(cridentialsRequired);

        }
        // POST api/<controller>/therest
        [HttpPost]
        [Route("Umalusi")]
        public string Umalusi(string value)
        {
            SOAPService soapObject = new SOAPService();
            string soap = soapObject.TherestResponse();

            return soap;
        }
        // POST api/<controller>/therest
        [HttpPost]
        [Route("Afiswitch")]
        public string Afiswitch(string value)
        {
            SOAPService soapObject = new SOAPService();
            return soapObject.TherestResponse();
        }
        // POST api/<controller>/therest
        [HttpPost]
        [Route("LexisNexis")]
        public string LexisNexis(string value)
        {
            SOAPService soapObject = new SOAPService();
            return soapObject.TherestResponse();
        }
        // POST api/<controller>/therest
        [HttpPost]
        [Route("MIE")]
        public string MIE(string value)
        {
            SOAPService soapObject = new SOAPService();
            return soapObject.TherestResponse();
        }
        // POST api/<controller>/therest
        [HttpPost]
        [Route("PNet")]
        public string PNet(string value)
        {
            SOAPService soapObject = new SOAPService();
            return soapObject.TherestResponse();
        }
        // POST api/<controller>/therest
        [HttpPost]
        [Route("Transunion")]
        public string Transunion(string value)
        {
            SOAPService soapObject = new SOAPService();
            return soapObject.TherestResponse();
        }
        // POST api/<controller>/therest
        [HttpPost]
        [Route("XDS")]
        public string XDS(string value)
        {
            SOAPService soapObject = new SOAPService();
            return soapObject.TherestResponse();
        }

        // POST api/<controller>/therest
        [HttpPost]
        [Route("Experian")]
        public string Experian(string value)
        {
            SOAPService soapObject = new SOAPService();
            return soapObject.TherestResponse();
        }
        // POST api/<controller>/therest
        [HttpPost]
        [Route("SAPS")]
        public string SAPS(string value)
        {
            SOAPService soapObject = new SOAPService();
            return soapObject.TherestResponse();
        }
        // POST api/<controller>/therest
        [HttpPost]
        [Route("FSCA")]
        public string FSCA(string value)
        {
            SOAPService soapObject = new SOAPService();
            return soapObject.TherestResponse();
        }
        // POST api/<controller>/therest
        [HttpPost]
        [Route("INSETA")]
        public string INSETA(string value)
        {
            SOAPService soapObject = new SOAPService();
            return soapObject.TherestResponse();
        }
        // POST api/<controller>/therest
        [HttpPost]
        [Route("TrafficDepartment")]
        public string TrafficDepartment(string value)
        {
            SOAPService soapObject = new SOAPService();
            return soapObject.TherestResponse();
        }
        // POST api/<controller>/therest
        [HttpPost]
        [Route("HomeAffairs")]
        public string HomeAffairs(string value)
        {
            SOAPService soapObject = new SOAPService();
            return soapObject.TherestResponse();
        }
        // POST api/<controller>/therest
        [HttpPost]
        [Route("SAQA")]
        public string SAQA(string value)
        {
            SOAPService soapObject = new SOAPService();
            return soapObject.TherestResponse();
        }
    }
}
