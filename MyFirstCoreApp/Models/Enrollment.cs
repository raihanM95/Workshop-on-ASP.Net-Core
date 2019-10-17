using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstCoreApp.Models
{
    public class Enrollment
    {
        public int Id { get; set; }

        [Display(Name = "Student Id")]
        public int StudentId { get; set; }
        public Student Student { get; set; }

        [Display(Name = "Course Id")]
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
