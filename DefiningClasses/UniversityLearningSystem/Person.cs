using System;

namespace UniversityLearningSystem
{
    using System;

    using UniversityLearningSystem.Exceptions;

    public abstract class Person : IPerson
    {
        private int age;

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value <= 0 || value > 100)
                {
                    throw new InvalidAgeException("Invalid age", 0, 100);
                }

                this.age = value;
            }
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

       // public abstract string ToString();

    }
}
