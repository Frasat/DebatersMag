﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DebatersMag.Models;

namespace DebatersMag.Controllers
{
    public class HomeController : Controller


    {

       

        public IActionResult Index()
        {
            return View();        }

        // public IActionResult About()
        // {
        //     ViewData["Message"] = "Your application description page.";

        //     return View();
        // }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Magazine()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Debate()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Profile()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult AboutUs()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

       


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
