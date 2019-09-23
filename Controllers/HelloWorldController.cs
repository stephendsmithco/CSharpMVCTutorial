using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CSharpMVCTutorial.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "Main Hello World route";
        }

        public string Welcome()
        {
            return "Welcome action method";
        }
    }
}