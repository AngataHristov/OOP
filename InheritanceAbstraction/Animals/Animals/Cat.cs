
namespace AnimalsType.Animals
{
    using System;

    using AnimalsType.Interfaces;

    public abstract class Cat : Animal, IAnimal, ISoundProducible
    {
        public Cat(string name, Genders gender, int age)
            : base(name, gender, age)
        {

        }
    }
}


