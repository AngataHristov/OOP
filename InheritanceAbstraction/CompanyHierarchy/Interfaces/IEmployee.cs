
namespace CompanyHierarchy.Interfaces
{
    using CompanyHierarchy.Enumerations;

    public interface IEmployee : IPerson
    {
        Departments Department { get; }

        decimal Salary { get; }
    }
}
