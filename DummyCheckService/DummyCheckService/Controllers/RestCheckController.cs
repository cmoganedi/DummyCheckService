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
        [HttpGet]
        [Route("ping")]
        public string ping()
        {
            return "API up and running!";
        }
        // GET: api/RestCheck
        [HttpPost]
        [Route("Compuscan")]
        public CreditCheck Compuscan([FromBody] JObject candidateDetails)
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
        [Route("XDS")]
        public bool XDS([FromBody] JObject candidateDetails)
        {
            return true;
        }

        // POST api/RestCheck
        [HttpPost]
        [Route("Exeperian")]
        public AcademicCheck Experian([FromBody] JObject candidateDetails)
        {
            AcademicCheck check = new AcademicCheck();
            check.name = candidateDetails["name"].ToString();
            check.surname = candidateDetails["surname"].ToString();
            check.idNr = (int)candidateDetails["id"];
            check.hasQualification = true;

            return check;
        }
    }
}
