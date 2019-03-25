using DesignPatternFactoryMethod.Product;

namespace DesignPatternFactoryMethod.ConcreteProduct
{
    // Concrete product ---> CitySavingAccounts which inherit saving account
    public class CitySavingAccounts : SavingsAccount
    {
        public CitySavingAccounts()
        {
            Balance = 5000;
        }


        public override decimal GetBalance()
        {
            return Balance;
        }
    }
}
