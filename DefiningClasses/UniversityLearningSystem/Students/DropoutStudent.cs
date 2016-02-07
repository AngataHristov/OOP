
namespace UniversityLearningSystem.Students
{
    using System;

    public class DropoutStudent : Student, IPerson
    {
        private string dropoutReason;

        public DropoutStudent(string firstName, string lastName, int age, string studentNumber, double averageGrade, string dropOutReason)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.DropoutReason = dropOutReason;
        }

        public string DropoutReason
        {
            get
            {
                return this.dropoutReason;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("No drop out readon seted!");
                }
                this.dropoutReason = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Last name: {1}, Age: {2}, Student number: {3}, Average grade: {4}, Dropout reason {5}",
                this.FirstName, this.LastName, this.Age, this.StudentNumber, this.AverageGrade, this.DropoutReason);
        }
    }
}
