using STDBind.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace STDBind.Controllers
{
    public class LoginController : Controller
    {
        StudentDbEntities2 db = new StudentDbEntities2();
        
        [HttpGet]
        public ActionResult login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult login(login_tbl s)
        {
            if (ModelState.IsValid == true)
            {
                var credentials = db.login_tbl.Where(model=>model.Name==s.Name && model.Password==s.Password).FirstOrDefault(); 
                if (credentials == null)
                {
                    ViewBag.FailedMessage = "Login Failed";
                    return RedirectToAction("login", "Login");
                }
                else
                {
                    Session["Name"]=s.Name;
                    return RedirectToAction("Index", "Student");
                }
            }
            return View();
        }
    }
}