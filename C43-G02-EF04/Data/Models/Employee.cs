using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G02_EF04.Data.Models
{
    public   class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public int Age { get; set; }

        //work
        [ForeignKey("Department")]
        public int? DepartmentDeptId { get; set; }
        [InverseProperty(nameof(Models.Department.Employees))]
        public virtual Department Department { get; set; }



        // mange one to one
       
        [InverseProperty(nameof(Models.Department.Manger))]
        public virtual Department? MangeDapartment { get; set; }
       
      
    }
}
