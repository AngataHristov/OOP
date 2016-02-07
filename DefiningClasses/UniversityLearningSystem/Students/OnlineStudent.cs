
namespace UniversityLearningSystem.Students
{
    using System;

    public class OnlineStudent : CurrentStudent, IPerson
    {
        public OnlineStudent(string firstName, string lastName, int age, string studentNumber, double averageGrade, string currentCourse)
            : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {

        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Last name: {1}, Age: {2}, Student number: {3}, Average grade: {4}, Current coure: {5}",
                this.FirstName, this.LastName, this.Age, this.StudentNumber, this.AverageGrade, this.CurrentCourse);
        }
    }
}
