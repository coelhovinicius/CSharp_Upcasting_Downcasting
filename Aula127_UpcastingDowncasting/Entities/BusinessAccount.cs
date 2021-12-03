﻿/* >>> SUBCLASSE BUSINESS ACCOUNT <<< */
namespace Aula127_UpcastingDowncasting.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        /* (: base (...)) - Permite herdar os construtores da Superclasse */
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base (number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
