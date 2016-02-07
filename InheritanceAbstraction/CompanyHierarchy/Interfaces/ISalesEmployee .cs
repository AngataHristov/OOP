
namespace CompanyHierarchy.Interfaces
{
    using System;
    using System.Collections.Generic;

    public interface ISalesEmployee : IEmployee, IPerson
    {
        ICollection<ISales> Sales { get; }
    }
}
