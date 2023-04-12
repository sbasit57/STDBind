using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STDBind.Models
{
    public class StudentViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Nullable<int> phone_number { get; set; }
        public string pdfname { get; set; }

        public HttpPostedFileBase PdfFile { get; set; }
    }
}