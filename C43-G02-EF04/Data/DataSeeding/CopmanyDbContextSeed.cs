using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using C43_G02_EF04.Data.Models;

namespace C43_G02_EF04.Data.DataSeeding
{
    internal class CopmanyDbContextSeed
    {
        public static void seed(CompanyDbContext dbContext)
        {
            #region departments
            #endregion
            if (!dbContext.Departments.Any())
            {
                var DeparmentData = File.ReadAllText("D:\\backend\\assignment\\c#\\New folder\\C43-G02-EF04\\C43-G02-EF04\\Data\\DataSeeding\\departments.json");

                var Deparments = JsonSerializer.Deserialize<List<Department>>(DeparmentData);

                if (Deparments?.Count() > 0)
                {
                    foreach (var Department in Deparments)
                    {
                        dbContext.Departments.Add(Department);
                    }
                }
            }


                #region Employee
                if (!dbContext.Employees.Any())
                {
                    var EmployeeData = File.ReadAllText("D:\\backend\\assignment\\c#\\New folder\\C43-G02-EF04\\C43-G02-EF04\\Data\\DataSeeding\\employees.json");

                    var Employees = JsonSerializer.Deserialize<List<Employee>>(EmployeeData);

                    if (Employees?.Count() > 0)
                    {
                        foreach (var employee in Employees)
                        {
                            dbContext.Employees.Add(employee);
                        }
                    dbContext.SaveChanges();
                }

                


                #endregion
            }

            
        }
    }
}
   
