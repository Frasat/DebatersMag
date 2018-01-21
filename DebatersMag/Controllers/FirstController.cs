using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DebatersMag.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DebatersMag.Controllers
{
    public class FirstController : Controller
    {
        private DebmagContext OurDBContext = null;

        public FirstController(DebmagContext _OurDBContext)
        {
            OurDBContext = _OurDBContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddUser(Users U)
        {
            using (var Tr = OurDBContext.Database.BeginTransaction())
            {
                try
                {
                    OurDBContext.Users.Add(U);
                    OurDBContext.SaveChanges();

                    Tr.Commit();


                }

                catch
                {
                    Tr.Rollback();
                }
            }
            return View();
        }
    }
}