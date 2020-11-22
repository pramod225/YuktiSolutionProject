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
                HttpCookie cookies = new HttpCookie("UserName");
                cookies.Value = txtUserName;
                Response.Cookies.Add(cookies);
                return RedirectToAction("Index", "Interviews");
            }
            else
            {
                return View();
            }
            
            
        }
    }
}


//namespace LMS_Mvc.Controllers
//{
//    public class LoginController : Controller
//    {
//        public UserDbContext db = new UserDbContext();
//        // GET: Login

//        public ActionResult Login()
//        {
//            return View();
//        }
//        [HttpPost]
//        public ActionResult Login(string txtUserName, int txtPassword)
//        {
//            var res = db.Users.Where(x => x.userName == txtUserName && x.password == txtPassword).FirstOrDefault();
//            if (res != null)
//            {
//                HttpCookie cookies = new HttpCookie("userName");
//                cookies.Value = txtUserName;
//                Response.Cookies.Add(cookies);
//                return RedirectToAction("Index", "Course");
//            }
//            else
//            {
//                return View();
//            }

//        }
//    }
//}