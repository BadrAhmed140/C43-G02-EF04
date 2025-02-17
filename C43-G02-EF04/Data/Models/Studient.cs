using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C43_G02_EF04.Data.Models
{
    public class Studient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        
        //many to many by data anotations
        public virtual ICollection<Stud_Course> Stud_Course { get; set; } = new HashSet<Stud_Course>();

        //many to many by convention
        // public ICollection<Course>  Courses { get; set; } = new HashSet<Course>();


    }
}
