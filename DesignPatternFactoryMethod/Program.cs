using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // created an instance of SavingAccountFactory and set as type ICreditUnionFactory
            var factory = new SavingAccountFactory() as ICreditUnionFactory;

            // call the city saving account object instance
            var cityAcct = factory.GetSavingsAccount("city-321");
            // call the national saving object instance 
            var nationalAcct = factory.GetSavingsAccount("national-321");

            Console.WriteLine($"My City balance is {cityAcct.Balance}" +
                              $" and National Balance is {nationalAcct.Balance}");

            Console.ReadKey();
        }
    }
}
