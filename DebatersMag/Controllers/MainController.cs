using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DebatersMag.Models;
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
        public IActionResult Eindex()
        {
            return View();
        }
        private DebmagContext OurDBContext = null;

        public MainController(DebmagContext _OurDBContext)
        {
            OurDBContext = _OurDBContext;
        }
        public IActionResult List()
        {

            return View(OurDBContext.Events.ToList<Events>());
        } 

}
    }
