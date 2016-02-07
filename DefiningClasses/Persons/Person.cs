// Problem 1.	Persons
// Define a class Person that has name, age and email.The name and age are mandatory.
// The email is optional.Define properties that accept non-empty name and age in the range [1 ... 100].
// In case of invalid arguments, throw an exception. Define a property for the email that accepts either
// null or non-empty string containing '@'. Define two constructors.The first constructor should take name,
// age and email.The second constructor should take name and age only and call the first constructor.
// Implement the ToString() method to enable printing persons at the console.

namespace Persons
{
    using System;

    public class Person
    {
        private string name;

        private int age;

        private string email;

        public Person()
        {

        }

        public Person(string initialName, int initialAge)
            : this(initialName, initialAge, "")
        {

        }

        public Person(string initialName, int initialAge, string initialEmail)
        {
            this.Name = initialName;
            this.Age = initialAge;
            this.Email = initialEmail;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name cannot be null or empty!");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("The age must be in the range [1...100].");
                }

                this.age = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && !value.Contains("@"))
                {
                    throw new ArgumentException("Email must contains @ character!");
                }

                this.email = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}, Email: {2}", this.Name, this.Age, string.IsNullOrEmpty(this.Email) ? "not set" : this.Email);
        }
    }
}
