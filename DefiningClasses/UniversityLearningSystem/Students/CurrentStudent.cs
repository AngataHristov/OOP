
namespace UniversityLearningSystem.Students
{
    using System;

    public abstract class CurrentStudent : Student, IPerson
    {
        private string currentCourse;

        public CurrentStudent(string firstName, string lastName, int age, string studentNumber, double averageGrade, string currentCourse)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.CurrentCourse = currentCourse;
        }

        public string CurrentCourse
        {
            get
            {
                return this.currentCourse;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Current course is not seted!");
                }
                this.currentCourse = value;
            }
        }
    }
}
