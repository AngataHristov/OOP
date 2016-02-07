
namespace BankOfKurtovoKonare.Accounts
{
    using System;

    using BankOfKurtovoKonare.Interfaces;

    public class LoanAccounts : Account, IAccount, IDepositable
    {
        public LoanAccounts(decimal balance, double interestRate, CustomerTypes customer)
            : base(balance, interestRate, customer)
        {

        }

        public override decimal CalculateInterestForGivenPeriod(double periodInMonths)
        {
            int monthsWithoutInterest = 0;
            switch (this.Customer)
            {
                case CustomerTypes.Companies:
                    monthsWithoutInterest = 2;
                    break;
                case CustomerTypes.Individuals:
                    monthsWithoutInterest = 3;
                    break;
            }

            int monthsWithInterest = (int)Math.Max(0, periodInMonths - monthsWithoutInterest);
            decimal interest = base.CalculateInterestForGivenPeriod(monthsWithInterest);

            return interest;
        }
    }
}
