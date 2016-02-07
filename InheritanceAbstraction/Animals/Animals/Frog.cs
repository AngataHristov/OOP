namespace AnimalsType.Animals
{
    using System;

    using AnimalsType.Interfaces;

    public class Frog : Animal, IAnimal, ISoundProducible
    {
        public Frog(string name, Genders gender, int age)
            : base(name, gender, age)
        {

        }

        public override string ProduceSound()
        {
            return string.Format("{0} says: Kwak, Kwak!", this.Name);
        }

    }
}