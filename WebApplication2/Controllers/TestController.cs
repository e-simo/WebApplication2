using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        [Route("api/test")]
        public IEnumerable<string> Get()
        {
            return new string[] { 
                "Response ", 
                "Web2", 
                "This is a  done in Feature1-Branch" ,
                "This is a modification 1 done in Feature2-Branch",
                "This is a modification 2 done to Feature2-Branch",
                "This temporarly in TempBranch-ToDelete",
                "Another temporarly something added in TempBranch-ToDelete"
            };
        }
    }
}
