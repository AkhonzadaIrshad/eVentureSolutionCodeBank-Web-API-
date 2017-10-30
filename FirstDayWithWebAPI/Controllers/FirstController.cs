using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstDayWithWebAPI.Controllers
{
    public class FirstController : ApiController
    {
        [HttpGet]
        public string FirstAPIMethod()
        {
            return "Welcome To WEB API's";
        }

        [HttpGet]
        public string SecondAPIMethod(int id)
        {
            return $"Your Parameter was {id}";
        }

        [HttpGet]
        public IHttpActionResult Login(string username, string password)
        {
            if (username.Equals("EvsLahore",StringComparison.CurrentCultureIgnoreCase)&&password.Equals("Admin"))
            {
                return Ok(new User(){Password = "Admin",UserName = "EvsLahore"});
            }
            else
            {
                return Ok("UserName or Password Invalid");
            }
        }
    }
}
