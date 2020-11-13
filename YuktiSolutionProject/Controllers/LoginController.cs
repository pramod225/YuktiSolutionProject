using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YuktiSolutionProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string txtUserName, string txtPassword)
        {
            if(txtUserName.Equals("hello")&& txtPassword.Equals("123") )
            {
                return RedirectToAction("Index", "Dashbord");
            }
            else
            {
                return View();
            }
            
            
        }
    }
}