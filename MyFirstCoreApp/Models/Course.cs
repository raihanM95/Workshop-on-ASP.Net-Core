using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstCoreApp.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        [Display(Name = "Course Code")]
        public string CourseCode { get; set; }
        [Required]
        [Display(Name = "Course Title")]
        public string CourseTitle { get; set; }
        [Required]
        [Display(Name = "Course Credit")]
        public int CourseCredit { get; set; }
    }
}
