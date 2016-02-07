
namespace HumanStudentWorker
{
    using System;

    public class Worker : Human
    {
        public Worker(string firstName, string lastName, int workHoursPerDay, decimal weekSalary)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary { get; private set; }

        public int WorkHoursPerDay { get; private set; }

        public decimal MoneyPerHour()
        {
            decimal result = (decimal)WeekSalary / (5 * WorkHoursPerDay);

            return result;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, money per hour: {2:F2}", this.FristName, this.LastName, this.MoneyPerHour());
        }
    }
}
