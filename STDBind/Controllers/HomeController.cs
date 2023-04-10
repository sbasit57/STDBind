using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace STDBind.Controllers
{
    public class HomeController : Controller
    {
        StudentDbEntities1 db = new StudentDbEntities1();
        public ActionResult Index()
        {
            List<Student_tbl> StudentList = db.Student_tbl.ToList();
            ViewBag.StudentList = new SelectList(StudentList, "Name", "Name");
            return View();
        }
        public JsonResult GetData(string Name)
        {
            var res = db.Student_tbl.Where(c => c.Name == Name).FirstOrDefault();

            Student_tbl stu = new Student_tbl
            {

                Name = res.Name,
                Email = res.Email,
                phone_number = res.phone_number
            };

            return Json(stu, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}