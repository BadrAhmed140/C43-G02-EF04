using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G02_EF04.Data.Models
{
    public class Department
    {
        public int? DepartmentId { get; set; }
        public string Name { get; set; }


        //manger one to one

        [ForeignKey("Manger")]
        public int? MangId { get; set; }
        [InverseProperty(nameof(Models.Employee.MangeDapartment))]
        public virtual Employee ?Manger { get; set; }

        //work one to many 

        [InverseProperty(nameof(Models.Employee.Department))]
        public virtual ICollection<Employee> ?Employees { get; set; } = new HashSet<Employee>();   
    }
}
