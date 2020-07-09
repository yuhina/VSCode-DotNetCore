
using Microsoft.AspNetCore.Mvc;

namespace CoreTest.Controllers
{
   
    public class HelloController:Controller
    {
        // [Route("Index")]
     
        public string Index()
        {
            
            return "hello world!";
        }

        // [Route("Welcome")]
          [HttpGet]
        public string Welcome()
        {
            return "welcome world..";
        }
    }


}