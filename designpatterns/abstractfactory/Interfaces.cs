using System;

namespace Interfaces
{
    public abstract class ICreditUnionFactory
    {
        public abstract ISavingsAccount CreateSavingsAccount();
        public abstract ILoanAccount CreateLoanAccount();
    }

    // Abstract Product A
    public interface ILoanAccount {}

    // Abstract Product B
    public interface ISavingsAccount {} 
}