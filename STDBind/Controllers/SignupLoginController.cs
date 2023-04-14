using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace STDBind.Controllers
{
    public class SignupLoginController : Controller
    {
        StudentDbEntities1 db = new StudentDbEntities1();

        // GET: SignupLogin
        public ActionResult login2()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Signup()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Signup(Student_tbl s)
        {
            if(ModelState.IsValid == true) 
            {
                db.Student_tbl.Add(s);
                int a = db.SaveChanges();
                if (a>0) 
                {
                    ViewBag.InsertMessage ="<script>alert('Registered Successfully')</script>";
                }
                else 
                {
                    ViewBag.InsertMessage = "<script>alert('Registeration Failed')</script>";
                }
            
            }
            return View();
        }
    }
}