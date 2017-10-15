using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTableToSingleTableConApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            MultiDbEntities1 cEntity = new MultiDbEntities1();
            cEntity.Database.Log = (log) => { Console.WriteLine(log); };

            #region Inserted Record

            Employee emp1 = new Employee { EmployeeID = 102, FirstName = "Vishal", LastName = "Nivate", Salary = 150000.00m };
            Employee emp2 = new Employee { EmployeeID = 104, FirstName = "Vivek", LastName = "Patil", Salary = 25000.00m };
            Employee emp3 = new Employee { EmployeeID = 105, FirstName = "Rakesh", LastName = "Rathod", Salary = 15622.00m };
            Employee emp4 = new Employee { EmployeeID = 106, FirstName = "Nitin", LastName = "Dive", Salary = 148222.00m };
            cEntity.Employees.Add(emp1);
            cEntity.Employees.Add(emp2);
            cEntity.Employees.Add(emp3);
            cEntity.Employees.Add(emp4);
            int receffected = cEntity.SaveChanges();
            Console.WriteLine($"{receffected} - records inserted succesfully");
            Console.ReadKey(true);
            var result = (from a in cEntity.Employees
                          select a).ToList();
            foreach (var item in result)
            {
                Console.WriteLine($"{item}");
            } 
            #endregion
        }
    }
}
