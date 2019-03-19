using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFactoryMethod
{
    // Product --> SavingAccounts
   public abstract class SavingsAccount
    {
        public decimal Balance { get; set; }
    }
}
