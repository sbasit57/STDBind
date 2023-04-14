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

    public partial class Student_tbl
    {
        public int ID { get; set; }

        [Display(Name = "Username")]
        [Required(ErrorMessage ="Username Required")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email Required")]
        [RegularExpression("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*",ErrorMessage ="Invalid Email")]
        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone No Required")]
        public Nullable<int> phone_number { get; set; }

        [Display(Name = "File Upload")]
        [Required(ErrorMessage = "Required")]
        public string pdfname { get; set; }

        [Display(Name = "Upload PDF")]
        [Required(ErrorMessage = "Required")]
        public HttpPostedFileBase PdfFile { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Required")]
        public string fname { get; set; }


        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Required")]
        public string lname { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        
        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Password)]
        [Compare("password",ErrorMessage ="Wrong Password")]
        public string confirm_password { get; set; }
    }
}
