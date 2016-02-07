
namespace CompanyHierarchy.Interfaces
{
    using System;
    using System.Collections.Generic;

    using CompanyHierarchy.People;

    public interface ICustomer : IPerson
    {
        decimal NetPurchaseAmount { get; }
    }
}
