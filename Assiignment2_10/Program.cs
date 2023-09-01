using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiignment2_10
{
    public  class BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; protected set; }

        public BankAccount(string account
         , string accountNumber
         , decimal balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }
    }
    public sealed class SavingsAccount :
        BankAccount
    {
        public double InterestRate { get; set; }
        public SavingsAccount(string accountNumber, decimal balance, double interestRate)
            : base(accountNumber, balance )
        {
            InterestRate = interestRate;
        }
        public void CalculateInterset()
        {
            decimal intersetAmount = (decimal)
                (Balance * (decimal)InterestRate);
            Balance += interestAmount;
        }

    }

}
