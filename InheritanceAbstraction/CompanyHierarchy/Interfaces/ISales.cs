
namespace CompanyHierarchy.Interfaces
{
    using System;

    public interface ISales
    {
        string ProductionName { get; }

        DateTime Date { get; }

        decimal Price { get; }
    }
}
