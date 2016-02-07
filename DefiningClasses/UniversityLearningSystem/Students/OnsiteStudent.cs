
namespace UniversityLearningSystem.Students
{
    using System;

    public class OnsiteStudent : CurrentStudent, IPerson
    {
        private int numberOfVisits;

        public OnsiteStudent(string firstName, string lastName, int age, string studentNumber, double averageGrade, string currentCourse, int visits)
            : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
            this.numberOfVisits = visits;
        }

        public int NumberOfVisits
        {
            get
            {
                return this.numberOfVisits;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The visits cannot be negative value!");
                }
                this.numberOfVisits = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Last name: {1}, Age: {2}, Student number: {3}, Average grade: {4}, Current coure: {5}",
                this.FirstName, this.LastName, this.Age, this.StudentNumber, this.AverageGrade, this.CurrentCourse);
        }
    }
}
