using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFactoryMethod
{
    // Concrete product ---> CitySavingAccounts which inherit saving account
    public class CitySavingAccounts : SavingsAccount
    {
        public CitySavingAccounts()
        {
            Balance = 5000;
        }
    }
}
