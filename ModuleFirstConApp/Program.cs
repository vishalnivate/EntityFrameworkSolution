using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFirstConApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            MultiDbModel2Container mCon = new MultiDbModel2Container();
            //mCon.Database.Log = (log) => Console.WriteLine(log);

            //Member m1 = new Member { MemberName = "Vishal" };
            //Member m2 = new Member { MemberName = "Deepak" };
            //Member m3 = new Member { MemberName = "Rahul" };
            //Member m4 = new Member { MemberName = "Bob" };
            //Game g1 = new Game { GameName = "Cricket", Fees = 1000 };
            //Game g2 = new Game { GameName = "Tennis", Fees = 1400 };
            //Game g3 = new Game { GameName = "Baseball", Fees = 1500 };
            //Game g4 = new Game { GameName = "FootBall", Fees = 1800 };
            //m1.Games.Add(g1);
            //m1.Games.Add(g2);
            //m2.Games.Add(g3);
            //m2.Games.Add(g2);
            //m3.Games.Add(g4);
            //m3.Games.Add(g3);
            //m4.Games.Add(g4);
            //mCon.Members.Add(m1);
            //mCon.Members.Add(m2);
            //mCon.Members.Add(m3);
            //mCon.Members.Add(m4);
            //int recEffected = mCon.SaveChanges();
            //Console.WriteLine($"{recEffected} - Records Inserted Succesfully");
            //Console.ReadKey(true);

            foreach (var item in mCon.Members)
            {
                Console.WriteLine($"Name: {item.MemberName} ");
                foreach (var gg in item.Games)
                {
                    Console.WriteLine($"Games: {gg.GameName} ,Fees :{gg.Fees}");
                }
            }

        }
    }
}
