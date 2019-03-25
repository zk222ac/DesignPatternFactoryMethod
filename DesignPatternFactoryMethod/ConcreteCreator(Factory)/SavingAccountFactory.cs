using System;
using DesignPatternFactoryMethod.ConcreteProduct;
using DesignPatternFactoryMethod.Product;

namespace DesignPatternFactoryMethod
{
    // Concrete Creator : which inherit interface ICreditUnionFactory
   public class SavingAccountFactory : ICreditUnionFactory
    {
        public SavingsAccount GetSavingsAccount(string acctNo)
        {
            
            if (acctNo.ToLower().Contains("city"))
            {
                return new CitySavingAccounts();
            }
            else if (acctNo.ToLower().Contains("national"))
            {
                return new NationalSavingAccounts();
            }
            else
            {
                throw  new ArgumentException("Invalid Account No");
            }
        }
    }
}
