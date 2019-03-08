using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

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
        public JObject Compuscan([FromBody] JObject candidateDetails)
        {   
            return JObject.FromObject(new Checks((string)candidateDetails["name"], (string) candidateDetails["surname"], (int) candidateDetails["id"], true));
        }

        // GET api/RestCheck/5
        [HttpPost]
        [Route("XDS")]
        public JObject XDS([FromBody] JObject candidateDetails)
        {
            return JObject.FromObject(new Checks((string) candidateDetails["name"], (string) candidateDetails["surname"], (int) candidateDetails["id"], false));
        }

        // POST api/RestCheck
        [HttpPost]
        [Route("Experian")]
        public JObject Experian([FromBody] JObject candidateDetails)
        {
            return JObject.FromObject(new Checks((string)candidateDetails["name"], (string)candidateDetails["surname"], (int)candidateDetails["id"], false));
        }
        // POST api/RestCheck
        [HttpGet]
        [Route("test")]
        public ActionResult test()
        {
            return Ok("New one works!");
        }

    }
}
