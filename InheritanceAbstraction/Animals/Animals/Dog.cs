
namespace AnimalsType.Animals
{
    using System;

    using AnimalsType.Interfaces;

    public class Dog : Animal, IAnimal, ISoundProducible
    {
        public Dog(string name, Genders gender, int age)
            : base(name, gender, age)
        {

        }

        public override string ProduceSound()
        {
            return string.Format("{0} says: Bau, Bau!", this.Name);
        }

    }
}
