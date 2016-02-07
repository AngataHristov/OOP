
namespace CompanyHierarchy.Interfaces
{
    using System;

    using CompanyHierarchy.Enumerations;

    public interface IProject
    {
        string ProjectName { get; }

        DateTime ProjectStartDate { get; }

        string Details { get; }

        ProjectState State { get; }

        void CloseProject();
    }
}
