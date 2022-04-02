using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
            

        [HttpGet]
        public ViewResult HelloWorld()
        {
            return View();
        }

        [HttpPost]
        public ViewResult HelloWorld(Name name)
        {
            if (ModelState.IsValid)
                return View("HelloName", name);
            else
                return View();
        }

        
       
    }
}
