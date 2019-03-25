namespace DesignPatternFactoryMethod.Product
{
    // Product --> SavingAccounts
   public abstract class SavingsAccount
    {
        protected decimal Balance { get; set; }

        public abstract decimal GetBalance();
    }
}
