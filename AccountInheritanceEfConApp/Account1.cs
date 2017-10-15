using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountInheritanceEfConApp
{
    public partial class Account
    {

        public override string ToString()
        {
            return string.Format($"AccountNo:{AccountNumber},Holder Name:-{HoldersName},Balance :-{Balance}");
        }
    }
}
