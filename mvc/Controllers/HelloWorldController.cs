using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvc.Models.Responses;
using Microsoft.AspNetCore.Mvc;

namespace mvc.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            var response = new HelloWorldModel { Message = "Hello World" };

            //return Ok(response);
            return View(response);
        }

        public IActionResult Welcome()
        {
            var response = new HelloWorldModel {Message = "Welcome World!"};

            return Ok(response);
        }
    }
}
