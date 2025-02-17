
using C43_G02_EF04.Data.DataSeeding;
using C43_G02_EF04.Data.Models;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        using CompanyDbContext dbCoontext = new CompanyDbContext();

        #region tph--tpcc
        //    FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
        //    {
        //        Name ="Badr",
        //        Age=28,
        //        Salary=51515,
        //        StartDate=DateTime.Now,
        //    };
        //PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
        //{
        //    Name = "nour",
        //    Age = 28,
        //    Salary = 51515,
        //    HourRate=22.5m
        //};
        //dbCoontext.Full_Time_Employees.Add(fullTimeEmployee);
        //dbCoontext.Part_Time_Employees.Add(partTimeEmployee);
        //dbCoontext.SaveChanges();
        #endregion
        #region dataseeding
        // CopmanyDbContextSeed.seed(dbCoontext);
        #endregion
        #region navigational property
        #region explicict loading
        #region ex1
        //var employee = (from E in dbCoontext.Employees
        //                where E.Id == 17
        //                select E).FirstOrDefault();
        //dbCoontext.Entry(employee).Reference(nameof(Employee.Department)).Load();
        //Console.WriteLine($"Employee Name:{employee.Name} :deppartment {employee.Department?.Name ?? "no department"}");
        #endregion

        #region ex2
        //var deparment = (from D in dbCoontext.Departments
        //                 where D.DepartmentId == 3
        //                 select D).FirstOrDefault();
        //Console.WriteLine($"deparment ID:{deparment.DepartmentId} :deppartment {deparment.Name}");

        //dbCoontext.Entry(deparment).Collection(nameof(Department.Employees)).Load();
        //foreach (var employee in deparment.Employees)
        //{

        //    Console.WriteLine($"Employee Name:{employee.Id} :deppartment {employee.Name}");
        //}
        #endregion
        #endregion
        #region egar loading
        #region ex1
        //var employee = (from E in dbCoontext.Employees.Include(e=>e.Department)
        //                where E.Id == 17
        //                select E).FirstOrDefault();

        //Console.WriteLine($"Employee Name:{employee.Name} :deppartment {employee.Department?.Name ?? "no department"}");
        #endregion

        //#region ex2
        //var deparment = (from D in dbCoontext.Departments.Include(e=>e.Employees)
        //                 where D.DepartmentId == 3
        //                 select D).FirstOrDefault();
        //Console.WriteLine($"deparment ID:{deparment.DepartmentId} :deppartment {deparment.Name}");

        //foreach (var employee in deparment.Employees)
        //{

        //    Console.WriteLine($"Employee Name:{employee.Id} :deppartment {employee.Name}");
        //}
        #endregion
        #region lazy loading
        #region ex1
        //var employee = (from E in dbCoontext.Employees
        //                where E.Id == 17
        //                select E).FirstOrDefault();

        //Console.WriteLine($"Employee Name:{employee.Name} :deppartment {employee.Department?.Name ?? "no department"}");
        #endregion

        //#region ex2
        //var deparment = (from D in dbCoontext.Departments
        //                 where D.DepartmentId == 3
        //                 select D).FirstOrDefault();
        //Console.WriteLine($"deparment ID:{deparment.DepartmentId} :deppartment {deparment.Name}");

        //foreach (var employee in deparment.Employees)
        //{

        //    Console.WriteLine($"Employee Name:{employee.Id} :deppartment {employee.Name}");
        //}
        #endregion
        #endregion



    }
}