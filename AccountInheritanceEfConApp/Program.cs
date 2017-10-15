using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInheritanceEfConApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            MultiDbEntities nEntity = new MultiDbEntities();
            nEntity.Database.Log = (log) => Console.WriteLine(log);
            #region Insert Record
            //Account sa1 = new SavingAccount
            //{
            //    AccountNumber = 102,
            //    HoldersName = "Vishal",
            //    Balance = 2015m
            //};
            //Account ca1 = new CurrentAccount
            //{
            //    AccountNumber = 103,
            //    HoldersName = "Rahul",
            //    Balance = 2015.54m
            //};
            //Account sa2 = new SavingAccount
            //{
            //    AccountNumber = 104,
            //    HoldersName = "TinTin",
            //    Balance = 100005m
            //};
            //Account ca2 = new CurrentAccount
            //{
            //    AccountNumber = 106,
            //    HoldersName = "Deven",
            //    Balance = 56844m
            //};
            //Account sa3 = new SavingAccount
            //{
            //    AccountNumber = 109,
            //    HoldersName = "Dilip",
            //    Balance = 58955m
            //};
            //Account ca3 = new CurrentAccount
            //{
            //    AccountNumber = 111,
            //    HoldersName = "Roshan",
            //    Balance = 45666m
            //};

            //nEntity.Accounts.Add(sa1);
            //nEntity.Accounts.Add(ca1);
            //nEntity.Accounts.Add(sa2);
            //nEntity.Accounts.Add(ca2);
            //nEntity.Accounts.Add(sa3);
            //nEntity.Accounts.Add(ca3);
            //int recEffected = nEntity.SaveChanges();
            //Console.WriteLine($"{recEffected} - Records Inserted Succesfully");

            //Console.ReadKey(true);

            //var result = nEntity.Accounts
            //                    .Select(c => new { c.AccountNumber, c.HoldersName, c.Balance, c.GetType().Name });
           
            var result = (from a in nEntity.Accounts
                          select a).ToList();
            foreach (var item in result)
            {
                Console.WriteLine($"{item} and Account Type: {item.GetType().Name}");
            }
            #endregion

        }
    }
}
