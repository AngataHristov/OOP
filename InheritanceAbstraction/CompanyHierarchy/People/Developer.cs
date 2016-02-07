
namespace CompanyHierarchy.People
{
    using System;
    using System.Collections.Generic;

    using CompanyHierarchy.Enumerations;
    using CompanyHierarchy.Interfaces;

    public class Developer : RegularEmployee, IDeveloper, IEmployee, IPerson
    {
        private ICollection<IProject> projects;

        public Developer(string firstName, string lastName, int id, Departments department, decimal salary)
            : base(firstName, lastName, id, department, salary)
        {
            this.Projects = new List<IProject>();
        }

        public ICollection<IProject> Projects
        {
            get
            {
                return new List<IProject>(this.projects);
            }
            set
            {
                this.projects = value;
            }
        }

        public void AddProject(IProject project)
        {
            this.projects.Add(project);
        }

        public override string ToString()
        {
            string result = base.ToString();
            result += string.Format("Role: Developer\n");
            result += string.Format("Projects: ");

            List<string> projectNames = new List<string>();
            foreach (var proj in this.Projects)
            {
                projectNames.Add(proj.ProjectName);
            }

            result += string.Join(", ", projectNames) + "\n";

            return result;
        }
    }
}
