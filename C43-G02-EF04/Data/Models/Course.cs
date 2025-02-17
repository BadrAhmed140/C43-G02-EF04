using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G02_EF04.Data.Models
{
    public class Course
    {

        public int Id { get; set; }
        public string Title { get; set; }

        //many to many by cdata anotations
        public virtual ICollection<Stud_Course> Stud_Course { get; set; } = new HashSet<Stud_Course>();



        //many to many by convention 
        // public ICollection<Studient> Studients { get; set; } = new HashSet<Studient>();
    }
}
