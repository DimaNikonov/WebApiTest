using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication3.Controllers
{
    public class HelloController : ApiController
    {
        private IGreeter greeter;

        public HelloController(IGreeter greeter)
        {
            this.greeter = greeter;
        }

        public string Get()
        {
            return greeter.SayHello();
        }
    }
}