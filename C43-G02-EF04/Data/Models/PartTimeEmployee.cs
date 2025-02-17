using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G02_EF04.Data.Models
{
    public class PartTimeEmployee:Employee
    {

        public int? CountOfHours { get; set; }
        public decimal? HourRate {set; get; }
    }
}
