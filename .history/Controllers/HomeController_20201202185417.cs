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
    public class HomeController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /) local host 5000
        //this will look for a file name called Index
        public IActionResult Index()
        {
            User someUser = new User()
            {
                FirstName ="bob",
                LastName="wilber"
            };

            return View("Index", someUser);
        }

        [HttpGet]
        [Route("numbers")]
        public IActionResult Numbers()
        {
            List<int> numberList = new List<int>(){1,2,3};
            return View("Numbers",numberList);   
        } 

        [HttpGet]
        [Route("user")]
        public IActionResult Person()
        {
            User someUser = new User()
            {
                FirstName = "janet",
                LastName = "stanen"
            };

            return View("user", someUser);
        }

        [HttpGet]
        [Route("people")]
        public IActionResult People()
        {
            List<User> persons = new List<User>()
            {
                new User() {FirstName="janet", LastName="stanen"},
                new User() {FirstName="thomas", LastName="bull"}
            };
            return View("People", persons);
        }
    }
}