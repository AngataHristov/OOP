
namespace UniversityLearningSystem.Students
{
    using System;

    public abstract class Student : Person, IPerson
    {
        private string studentNumber;
        private double averageGrade;

        public Student(string firstName, string lastName, int age, string studentNumber, double averageGrade)
            : base(firstName, lastName)
        {
            this.Age = age;
            this.AverageGrade = averageGrade;
            this.StudentNumber = studentNumber;
        }

        public string StudentNumber
        {
            get
            {
                return this.studentNumber;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The student number cannot be null or empty space!");
                }

                this.studentNumber = value;
            }
        }

        public double AverageGrade
        {
            get
            {
                return this.averageGrade;
            }
            private set
            {
                if (value < 2)
                {
                    throw new ArgumentOutOfRangeException("The average grade cannot be smaller than poor(2) !");
                }

                this.averageGrade = value;
            }
        }
    }
}
