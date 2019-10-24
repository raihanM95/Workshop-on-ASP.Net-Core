using MyFirstCoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstCoreApp.ViewModels
{
    public class StudentsViewModel
    {
        public Student Student { get; set; }
        public IEnumerable<Student> Students { get; set; }
    }
}
