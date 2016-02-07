
namespace AnimalsType.Animals
{
    using System;

    using AnimalsType.Interfaces;

    public class TomCat : Cat, IAnimal, ISoundProducible
    {
        public TomCat(string name, int age)
            : base(name, Genders.Male, age)
        {
            this.Gender = Genders.Male;
        }

        public override string ProduceSound()
        {
            return string.Format("{0} says: Meow, Meow!", this.Name);
        }

    }
}



