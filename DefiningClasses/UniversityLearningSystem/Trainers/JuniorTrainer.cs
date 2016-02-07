
namespace UniversityLearningSystem.Trainers
{
    using System;
    using UniversityLearningSystem.Exceptions;

    public class JuniorTrainer : Trainer, IPerson
    {
        public JuniorTrainer(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {

        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Last name: {1}, Age: {2}", this.FirstName, this.LastName, this.Age);
        }
    }
}
