
namespace BankOfKurtovoKonare.Interfaces
{
    public interface IAccount
    {
        CustomerTypes Customer { get; }

        decimal Balance { get; }

        double InterestRate { get; }

        decimal CalculateInterestForGivenPeriod(double preriodInMonths);
    }
}
