using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Names()
        {
            // to a View that has defined a model as @model string[]
            string[] names = new string[]
            {
            "Sally", "Billy", "Joey", "Moose"
            };
            return View(names);
        }
    }
}