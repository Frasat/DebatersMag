using System.Linq;
using DebatersMag.Models;
using Microsoft.AspNetCore.Mvc;
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
           // ViewBag.Username = System.Web.HttpContext.Current.User;
            //Welcome.Text = "Hi " + OurDBContext<Users>.Model.FirstName;
            //  Users U = new Users();
            //  ViewBag.Name = User.Identity.Name.ToString();
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
                    if (ModelState.IsValid)
                    {
                        OurDBContext.Users.Add(U);
                        OurDBContext.SaveChanges();

                        Tr.Commit();
                    }
                    


                }

                catch
                {
                    Tr.Rollback();
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string useremail, string userpassword)
        {
            Users obj = OurDBContext.Users.Where(abc => abc.Email == useremail).FirstOrDefault();
            if (obj.Password == userpassword)
            {
              //  lblUsername.Text = Session("username");
                //  Session["username"] = TextBox1.Text;
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

        }
    }
}