
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
        #region join (inter join )
        //var result = from D in dbCoontext.Employees
        //             join E in dbCoontext.Departments
        //             on D.DepartmentDeptId equals E.DepartmentId
        //             select new
        //             {
        //                 EmpId = E.DepartmentId,
        //                 name = E.Name,
        //                 deptId = D.Id,
        //                 deptName = D.Name,
        //             };
        ////Fluent Syntax
        //result = dbCoontext.Employees.Join(dbCoontext.Departments,
        //    D => D.DepartmentDeptId,
        //    E => E.DepartmentId,
        //    (Department, Employee) => new
        //    {
        //        EmpId = Employee.DepartmentId,
        //        name = Employee.Name,
        //        deptId = Department.Id,
        //        deptName = Department.Name,
        //    });
        //foreach (var item in result) { 
        //Console.WriteLine(item);
        //}
        #endregion
        #region (Group Join)
        //Fluent Syntax
        //var result = dbCoontext.Departments.GroupJoin(dbCoontext.Employees,
        //    D => D.DepartmentId,
        //    E => E.DepartmentDeptId,
        //    (Department, Employee) => new
        //    {
        //        Department,
        //        Employee
        //    });

        //var result = from D in dbCoontext.Departments
        //             join E in dbCoontext.Employees
        //             on D.DepartmentId equals E.DepartmentDeptId into emp
        //             select new
        //             {
        //                 dept=D,
        //                 employess=emp
        //             };
        //foreach (var item in result)
        //{
        //    Console.WriteLine(item.dept.DepartmentId);
        //    foreach (var emp in item.employess)
        //    {
        //        Console.WriteLine(emp.Name);
        //    }
        //}
        #endregion
        #region outer join 
        //var result = dbCoontext.Employees
        //    .GroupJoin(dbCoontext.Departments,
        //e => e.DepartmentDeptId,   
        //d => d.DepartmentId,             
        //(employee, departments) => new { employee, departments })
        //     .SelectMany(
        //ed => ed.departments.DefaultIfEmpty(),  
        //(ed, department) => new
        //{
        //    EmpId = ed.employee.Id,
        //    Name = ed.employee.Name,
        //    DeptId = department != null ? department.DepartmentId : (int?)null,  
        //    DeptName = department != null ? department.Name : "No Department"
        //});

        //foreach (var item in result)
        //{
        //    Console.WriteLine($"EmpId: {item.EmpId}, Name: {item.Name}, DeptId: {item.DeptId}, DeptName: {item.DeptName}");
        //}

        #endregion
        #region cross join 
        //var result = from E in dbCoontext.Employees
        //             from D in dbCoontext.Departments 
                    
        //             select new
        //             {
        //                emp= E,
        //                Department =D
        //             };
        //foreach (var item in result)
        //{
        //    Console.WriteLine(item.emp.Name);
           
        //
        //}
        #endregion
        #endregion

    }
}