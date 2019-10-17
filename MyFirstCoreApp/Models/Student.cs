using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstCoreApp.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "ID")]
        //[StringLength(10, MinimumLength = 5)]
        //[MinLength(6, ErrorMessage = "ID minimum 6 character required")]
        public string StudentId { get; set; }
        public string Name { get; set; }
        public string Semester { get; set; }
    }
}
