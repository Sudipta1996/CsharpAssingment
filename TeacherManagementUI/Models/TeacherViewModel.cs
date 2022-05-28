using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeacherManagementUI.Models
{
    public class TeacherViewModel
    {
        public int Id { get; set; }
        //[Required(ErrorMessage = "First Name is required")]
        //[StringLength(50, MinimumLength = 3)]
        //[Display(Name = "First Name")]
        public string Name { get; set; }

        //[Required(ErrorMessage = "Last Name is required")]
        //[StringLength(50, MinimumLength = 0)]
        //[Display(Name = "Last Name")]
        public string Email { get; set; }

        //[Required(ErrorMessage = "Age is required")]
        //[Range(typeof(int), "18", "60", ErrorMessage = "Age must be between 18 and 40")]
    }
}