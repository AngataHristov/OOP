
namespace UniversityLearningSystem.Trainers
{
    using System;

    class SeniorTrainer : Trainer, IPerson
    {
        public SeniorTrainer(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {

        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Last name: {1}, Age: {2}", this.FirstName, this.LastName, this.Age);
        }

        public void DeleteCourse(string courseName)
        {
            base.listOfCourses.Remove(courseName);

            Console.WriteLine("The course \"{0}\" has been deleted by {1} {2}.", courseName,this.FirstName,this.LastName);
        }
    }
}
