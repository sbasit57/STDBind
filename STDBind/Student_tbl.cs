//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace STDBind
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web;
    using System.Xml.Linq;

    public partial class Student_tbl
    {
        public int ID { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }

        [Display(Name = ("Username"))]
        [Required(ErrorMessage = "Username is required")]
        public string Name { get; set; }
        public string Email { get; set; }
        public Nullable<int> phone_number { get; set; }
        public string pdfname { get; set; }
        public HttpPostedFileBase PdfFile { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password is required")]
        public string password { get; set; }
    }
}
