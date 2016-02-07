
namespace HumanStudentWorker
{
    using System;

    public abstract class Human
    {
        public Human(string firstName, string lastName)
        {
            this.FristName = firstName;
            this.LastName = lastName;
        }

        public string FristName { get; private set; }

        public string LastName { get; private set; }
    }
}
