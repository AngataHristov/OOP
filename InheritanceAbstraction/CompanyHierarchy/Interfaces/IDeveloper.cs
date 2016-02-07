
namespace CompanyHierarchy.Interfaces
{
    using System;
    using System.Collections.Generic;

    public interface IDeveloper : IEmployee, IPerson
    {
        ICollection<IProject> Projects { get; }
    }
}
