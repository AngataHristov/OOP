
namespace BankOfKurtovoKonare.Accounts
{
    using System;

    using BankOfKurtovoKonare.Interfaces;

    public class MortgageAccounts : Account, IAccount, IDepositable
    {
        public MortgageAccounts(decimal balance, double interestRate, CustomerTypes customer)
            : base(balance, interestRate, customer)
        {

        }

        public override decimal CalculateInterestForGivenPeriod(double periodInMonths)
        {
            int monthsWithFullInterest;
            decimal interest = 0;

            switch (this.Customer)
            {
                case CustomerTypes.Companies:
                    int monthsWithHalfInterest = 12;
                    interest += this.Balance *(decimal)(1 + ((decimal)this.InterestRate / 2 * (decimal)periodInMonths));
                    monthsWithFullInterest = (int)Math.Max(0, periodInMonths - monthsWithHalfInterest);
                    interest += base.CalculateInterestForGivenPeriod(monthsWithFullInterest);
                    break;
                case CustomerTypes.Individuals:
                    int monthsWithNoInterest = 6;
                    monthsWithFullInterest = (int)Math.Max(0, periodInMonths - monthsWithNoInterest);
                    interest = base.CalculateInterestForGivenPeriod(monthsWithFullInterest);
                    break;
            }

            return interest;
        }
    }
}
