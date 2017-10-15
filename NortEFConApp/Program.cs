using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NortEFConApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            NorthwindEntities nEntity = new NorthwindEntities();
            nEntity.Database.Log = (log) => Console.WriteLine(log);

            #region Get All Customer from City "Londan"
            //var result = (from c in nEntity.Customers
            //              where c.City == "London"
            //              select new { c.CustomerID, c.CompanyName, c.City, c.Country });
            //var result = nEntity.Customers.Where(c => c.City == "London")
            //                    .Select(c => new { c.CustomerID, c.CompanyName, c.City, c.Country });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Inserted
            // Customer cusRec = new Customer
            // {
            //     CustomerID = "10092",
            //     CompanyName = "HDFC",
            //     ContactName = "Jignesh",
            //     City = "Mumbai",
            //     Country = "India"
            // };
            //nEntity.Customers.Add(cusRec);
            // try
            // {
            //     nEntity.SaveChanges();
            //     Console.WriteLine("Inserted Succesfully...");
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine(ex.ToString());
            //     throw;
            // }

            #endregion

            #region Updated
            //var cust = nEntity.Customers.FirstOrDefault(c => c.CustomerID == "10092");
            //Console.WriteLine(cust);
            //cust.City = "Thane";
            //Console.ReadKey(true);
            //try
            //{
            //    nEntity.SaveChanges();
            //    Console.WriteLine("Updated Succesfully..");
            //}
            //catch (System.Data.Entity.Infrastructure.DbUpdateConcurrencyException ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //    var data = ex.Entries.Single();
            //    var originalvalues = data.OriginalValues;
            //    var currentvalues = data.CurrentValues;
            //    var databasevalues = data.GetDatabaseValues();

            //    Console.WriteLine("--------------------------------------------------");
            //    Console.WriteLine("Original Values\n");
            //    Console.WriteLine($"torginalvalues.GetValues<string>('City')->{originalvalues.GetValue<string>("City")}");
            //    Console.WriteLine("Current Values\n");
            //    Console.WriteLine($"tcurrentvalues.GetValues<string>('City')->{currentvalues.GetValue<string>("City")}");
            //    Console.WriteLine("Original Values\n");
            //    Console.WriteLine($"tdatabasevalues.GetValues<string>('City')->{databasevalues.GetValue<string>("City")}");
            //    Console.WriteLine("---------------------------------------------------");
            //    Console.ReadKey(true);
            //    data.OriginalValues.SetValues(data.GetDatabaseValues());
            //    nEntity.SaveChanges();

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}

            #endregion

            #region Deleted
            var cust = nEntity.Customers.FirstOrDefault(c => c.CustomerID == "10092");
            Console.WriteLine(cust);
            Console.WriteLine("Press Any key to Dealted Customer");
            Console.ReadKey(true);
            nEntity.Customers.Remove(cust);
            try
            {
                nEntity.SaveChanges();
                Console.WriteLine("deleted succesfully..");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            #endregion
        }
    }
}
