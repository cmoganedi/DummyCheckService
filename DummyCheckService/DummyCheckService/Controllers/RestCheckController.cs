using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using DummyCheckService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DummyCheckService.Controllers
{
    [Route("api/[controller]")]
    public class RestCheckController : Controller
    {
        // GET: api/RestCheck
        [HttpPost]
        [Route("GetCreditCheck")]
        public CreditCheck GetCreditCheck([FromBody] JObject candidateDetails)
        {
            CreditCheck check = new CreditCheck();
            check.name = candidateDetails["name"].ToString();
            check.surname = candidateDetails["surname"].ToString();
            check.idNr = (int) candidateDetails["id"];
            check.creditScore = 770;

            return check;
        }

        // GET api/RestCheck/5
        [HttpPost]
        [Route("GetIdentityCheck")]
        public bool GetIdentityCheck([FromBody] JObject candidateDetails)
        {
            return true;
        }

        // POST api/RestCheck
        [HttpPost]
        [Route("GetAcademicCheck")]
        public AcademicCheck GetAcademicCheck([FromBody] JObject candidateDetails)
        {
            AcademicCheck check = new AcademicCheck();
            check.name = candidateDetails["name"].ToString();
            check.surname = candidateDetails["surname"].ToString();
            check.idNr = (int)candidateDetails["id"];
            check.hasQualification = true;
            return check;
        }

        // POST api/RestCheck
        [HttpPost]
        [Route("GetDriversCheck")]
        public bool GetDriversCheck([FromBody] JObject candidateDetails)
        {
            return true;
        }

        // POST api/RestCheck
        [HttpPost]
        [Route("GetCriminalCheck")]
        public CriminalCheck GetCriminalCheck([FromBody] JObject candidateDetails)
        {
            CriminalCheck check = new CriminalCheck();
            check.name = candidateDetails["name"].ToString();
            check.surname = candidateDetails["surname"].ToString();
            check.idNr = (int)candidateDetails["id"];
            check.CriminalRecords = new string []{"Murder", "Arson"};
            return check;
        }
    }
}
