
namespace AnimalsType.Animals
{
    using System;

    using AnimalsType.Interfaces;

    public class Kitten : Cat, IAnimal, ISoundProducible
    {
        public Kitten(string name, int age)
            : base(name, Genders.Female, age)
        {

        }

        public override string ProduceSound()
        {
            return string.Format("{0} says: Meow, Meow!", this.Name);
        }

    }
}



