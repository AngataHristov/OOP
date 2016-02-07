
namespace UniversityLearningSystem.Students
{
    using System;

    public class GraduatedStudent : Student, IPerson
    {
        public GraduatedStudent(string firstName, string lastName, int age, string studentNumber, double averageGrade)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {

        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Last name: {1}, Age: {2}, Student number: {3}, Average grade: {4}",
                this.FirstName, this.LastName, this.Age, this.StudentNumber, this.AverageGrade);
        }
    }
}
