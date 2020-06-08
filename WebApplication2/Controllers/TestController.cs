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
                "This is a modification done in Feature1-Branch" ,
                "This is a modification done in Feature2-Branch" 
            };
        }
    }
}
