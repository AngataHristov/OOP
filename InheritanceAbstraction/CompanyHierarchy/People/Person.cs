
namespace CompanyHierarchy.People
{
    using System;

    using CompanyHierarchy.Interfaces;

    public abstract class Person : IPerson
    {
        private string firstName;

        private string lastName;

        private int id;

        public Person(string firstName, string lastName, int id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ID = id;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty!");
                }

                this.lastName = value;
            }
        }

        public int ID
        {
            get
            {
                return this.id;
            }
            private set
            {
                if (value == 0)
                {
                    throw new ArgumentException("ID cannot be 0!");
                }

                this.id = value;
            }
        }

        public override string ToString()
        {
            return string.Format(
                "ID: {0}\nFirst Name: {1}\nLast Name: {2}\n",
                this.ID,
                this.FirstName,
                this.LastName);
        }
    }
}
