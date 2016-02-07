
namespace BankOfKurtovoKonare
{
    using System;
    using System.Collections.Generic;

    using BankOfKurtovoKonare.Accounts;
    using BankOfKurtovoKonare.Interfaces;

    public class BankMain
    {
        public static void Main()
        {
            var accounts = new List<Account>
           {
                new DepositAccounts( 1050.25m, 0.0055, CustomerTypes.Individuals),
                new LoanAccounts( -10000, 0.0005, CustomerTypes.Companies),
                new MortgageAccounts( -50000, 0.0011, CustomerTypes.Individuals),
                new DepositAccounts(1000000, 0.00075, CustomerTypes.Companies),
            };

            Console.WriteLine(
                "12-month interest on a deposit account (balance: {0:c2}, rate: {1:f3}%): {2:c2}",
                accounts[0].Balance,
                accounts[0].InterestRate * 100,
                accounts[0].CalculateInterestForGivenPeriod(12));

            Console.WriteLine(
                "3-month interest on a loan account (balance: {0:c2}, rate: {1:f3}%): {2:c2}",
                accounts[1].Balance,
                accounts[1].InterestRate * 100,
                accounts[1].CalculateInterestForGivenPeriod(3));

            Console.WriteLine(
                "15-month interest on a mortgage account (balance: {0:c2}, rate: {1:f3}%): {2:c2}",
                accounts[2].Balance,
                accounts[2].InterestRate * 100,
                accounts[2].CalculateInterestForGivenPeriod(15));

            Console.WriteLine(
                "24-month interest on a deposit account (balance: {0:c2}, rate: {1:f3}%): {2:c2}",
                accounts[3].Balance,
                accounts[3].InterestRate * 100,
                accounts[3].CalculateInterestForGivenPeriod(24));
        }
    }
}
