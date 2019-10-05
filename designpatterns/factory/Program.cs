using System;

namespace factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new SavingsAcctFactory() as ICreditUnionFactory;
            var citiAcct = factory.GetSavingsAccount("CITI-321");
            var nationalAcct = factory.GetSavingsAccount("NATIONAL-987");

            Console.WriteLine($"Citi balance is ${citiAcct.Balance}\n"
                            + $"National balance is ${nationalAcct.Balance}");
        }
    }

    // Product
    public abstract class ISavingsAccount
    {
        public decimal Balance { get; set; }
    }

    // Concrete Product
    public class CitiSavingsAcct : ISavingsAccount
    {
        public CitiSavingsAcct()
        {
            Balance = 5000;
        }
    }

    // Concrete Product
    public class NationalSavingsAcct : ISavingsAccount
    {
        public NationalSavingsAcct()
        {
            Balance = 2000;
        }
    }

    // Creator
    interface ICreditUnionFactory
    {
        ISavingsAccount GetSavingsAccount(string acctNo);
    }

    // Concrete Creators
    public class SavingsAcctFactory : ICreditUnionFactory
    {
        public ISavingsAccount GetSavingsAccount(string acctNo)
        {
            if (acctNo.Contains("CITI"))
                return new CitiSavingsAcct();
            
            if (acctNo.Contains("NATIONAL"))
                return new NationalSavingsAcct();
            
            else
                throw new ArgumentException("Invalid Account Number");
        }
    }
}
