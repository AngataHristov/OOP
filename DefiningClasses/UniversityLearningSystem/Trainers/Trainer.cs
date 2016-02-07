
namespace UniversityLearningSystem.Trainers
{
    using System;
    using System.Collections.Generic;

    public abstract class Trainer : Person, IPerson
    {
        protected List<string> listOfCourses;

        public Trainer(string firstName, string lastName, int age)
            : base(firstName, lastName)
        {
            this.Age = age;
            this.ListOfCourses = new List<string>();
        }

        public List<string> ListOfCourses
        {
            get
            {
                return new List<string>(this.listOfCourses);
            }
            set
            {
                this.listOfCourses = value;
            }
        }

        public void CreateCourse(string courseName)
        {
            this.listOfCourses.Add(courseName);
            Console.WriteLine("The course \"{0}\" has been created by {1} {2}.", courseName, this.FirstName, this.LastName);
        }
    }
}
