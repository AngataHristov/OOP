
namespace AnimalsType.Animals
{
    using System;

    using AnimalsType.Interfaces;

    public abstract class Animal : IAnimal, ISoundProducible
    {
        private int age;

        private string name;

        public Animal(string name, Genders gender, int age = 0)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be negative!");
                }
                this.age = value;
            }
        }

        public Genders Gender { get; protected set; }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name must be at least 3 symbols!");
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty!");
                }
                this.name = value;
            }
        }

        // string , a ne void , poradi suobrajeniq s KPK
        public abstract string ProduceSound();
    }
}
