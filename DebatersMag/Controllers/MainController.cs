﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DebatersMag.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Article()
        {
            return View();
        }
    }
}