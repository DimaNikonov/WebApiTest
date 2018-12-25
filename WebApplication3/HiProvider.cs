using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Controllers;

namespace WebApplication3
{
    public class HiProvider : IGreeter
    {
        public string SayHello()
        {
            return "Hi there";
        }
    }
}