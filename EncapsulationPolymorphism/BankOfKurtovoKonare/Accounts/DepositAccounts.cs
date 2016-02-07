
namespace BankOfKurtovoKonare.Accounts
{
    using System;

    using BankOfKurtovoKonare.Interfaces;

    public class DepositAccounts : Account, IAccount, IDepositable, IWithdrawable
    {
        public DepositAccounts(decimal balance, double interestRate, CustomerTypes customer)
            : base(balance, interestRate, customer)
        {

        }

        public override decimal CalculateInterestForGivenPeriod(double periodInMonths)
        {
            decimal result = new decimal();

            if (this.Balance < 1000 && this.Balance > 0)
            {
                result = base.CalculateInterestForGivenPeriod(0);
            }
            else
            {
                result = base.CalculateInterestForGivenPeriod(periodInMonths);
            }

            return result;
        }

        public void WithdrawMoney(decimal withdrawAmount)
        {
            this.Balance -= withdrawAmount;
        }
    }
}
