using System;
using Interfaces;

namespace CitiCreditUnion
{
    // Concrete Product
    public class CitiSavingsAccout : ISavingsAccount
    {
        public CitiSavingsAccout()
        {
            Console.WriteLine("Returned Citi Savings Account");
        }
    }

    // Concrete ProductB1
    public class CitiLoanAccount : ILoanAccount
    {
        public CitiLoanAccount()
        {
            Console.WriteLine("Returned Citi Loan Account");
        }
    }

    // Concrete Factory 1
    public class CitiCreditUnionFactory : ICreditUnionFactory
    {
        public override ILoanAccount CreateLoanAccount()
        {
            CitiLoanAccount obj = new CitiLoanAccount();
            return obj;
        }

        public override ISavingsAccount CreateSavingsAccount()
        {
            CitiSavingsAccout obj = new CitiSavingsAccout();
            return obj;
        }
    }
}