
namespace BankOfKurtovoKonare.Accounts
{
    using System;

    using BankOfKurtovoKonare.Interfaces;

    public abstract class Account : IAccount, IDepositable
    {
        private double interestRate;

        public Account(decimal balance, double interestRate, CustomerTypes customer)
        {
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.Customer = customer;
        }

        public decimal Balance { get; protected set; }

        public CustomerTypes Customer { get; protected set; }

        public double InterestRate
        {
            get
            {
                return this.interestRate;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest rate cannot be negative!");
                }

                this.interestRate = value;
            }
        }

        public virtual decimal CalculateInterestForGivenPeriod(double periodInMonths)
        {
            decimal result = this.Balance * (decimal)(1 + InterestRate * periodInMonths);

            return result;
        }

        public void DepositMoney(decimal depositAmount)
        {
            this.Balance += depositAmount;
        }

    }
}
