using DesignPatternFactoryMethod.Product;

namespace DesignPatternFactoryMethod.ConcreteProduct
{
    // Concrete product ---> CitySavingAccounts which inherit saving account
    public class NationalSavingAccounts : SavingsAccount
    {
        public NationalSavingAccounts()
        {
            Balance = 2000;
        }

        public override decimal GetBalance()
        {
            return Balance;
        }
    }
}
