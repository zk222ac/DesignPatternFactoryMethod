using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFactoryMethod
{
    // Creator  --> we called interface ICreditUnionFactory
    interface ICreditUnionFactory
    {
        // This abstract method return the Type of SavingAccount which takes accountNumber as a input 
        SavingsAccount GetSavingsAccount(string acctNo);
    }
}
