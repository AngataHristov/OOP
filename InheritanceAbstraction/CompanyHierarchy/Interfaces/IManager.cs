
namespace CompanyHierarchy.Interfaces
{
    using System;
    using System.Collections.Generic;

    public interface IManager : IPerson
    {
        ICollection<IEmployee> EmployeesManaged { get; }
    }
}
