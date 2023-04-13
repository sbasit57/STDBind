using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace STDBind.Controllers
{
    public class SignupLoginController : Controller
    {
        // GET: SignupLogin
        public ActionResult login()
        {
            return View();
        }
        public ActionResult Signup()
        {
            return View();
        }
    }
}