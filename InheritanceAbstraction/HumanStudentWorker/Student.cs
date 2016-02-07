
namespace HumanStudentWorker
{
    using System;

    public class Student : Human
    {
        private int facultyNumber;

        public Student(string firstName, string lastName, int facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public int FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            private set
            {
                if (value.ToString().Length < 5 || value.ToString().Length > 10)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.FristName, this.LastName);
        }
    }
}
