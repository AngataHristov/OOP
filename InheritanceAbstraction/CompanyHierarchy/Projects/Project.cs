
namespace CompanyHierarchy.Projects
{
    using System;
    using System.Collections.Generic;

    using CompanyHierarchy.Enumerations;
    using CompanyHierarchy.Interfaces;

    public class Project : IProject
    {
        private string projectName;

        public Project(string projectName, DateTime projectStateDate, ProjectState state)
        {
            this.ProjectName = projectName;
            this.ProjectStartDate = projectStateDate;
            this.State = state;
        }

        public Project(string projectName, DateTime projectStateDate, ProjectState state, string details)
            : this(projectName, projectStateDate, state)
        {
            this.Details = details;
        }

        public string ProjectName
        {
            get
            {
                return this.projectName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null!");
                }

                this.projectName = value;
            }
        }

        public string Details { get; set; }

        public DateTime ProjectStartDate { get; private set; }

        public ProjectState State { get; private set; }

        public void CloseProject()
        {
            this.State = ProjectState.Closed;
        }

        public override string ToString()
        {
            return string.Format(
                "Project: {0} (started: {1}, status: {3}) - {2}",
                this.ProjectName,
                this.ProjectStartDate.Date,
                this.Details,
                this.State);
        }
    }
}
