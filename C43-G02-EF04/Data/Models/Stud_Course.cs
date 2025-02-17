using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G02_EF04.Data.Models
{
    public class Stud_Course
    {

        [Key]
        [ForeignKey("Student")]
        public int stud_ID { get; set; }

        [Key]
        [ForeignKey("Course")]
        public int Course_ID { get; set; }

        public float Grade { get; set; }

        public virtual Studient Student { get; set; }
        public virtual Course Course { get; set; }
    }
}
