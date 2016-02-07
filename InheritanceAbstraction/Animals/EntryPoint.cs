
namespace AnimalsType
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using AnimalsType.Animals;

    public class EntryPoint
    {
        public static void Main()
        {
            var animals = new List<Animal>
            {
                new Dog("Sharo",Genders.Male, 12 ),
                new Frog("Froggy",Genders.Female, 1 ),
                new Kitten("Kitty", 3),
                new Kitten("Katya", 4),
                new TomCat("Gosho", 5),
                new TomCat("Assen", 2),
                new Frog("Hopper",Genders.Female, 2 ),
                new Dog("Murdzho",Genders.Male, 17 )
            };

            double dogsAverageAge = animals.Where(a => a is Dog).Average(d => d.Age);

            double frogsAverageAge = animals.Where(a => a is Frog).Average(f => f.Age);

            double catsAverageAge = animals.Where(a => a is Cat).Average(c => c.Age);

            Console.WriteLine("Dogs average age: " + dogsAverageAge);

            Console.WriteLine("Frogs average age: " + frogsAverageAge);

            Console.WriteLine("Cats average age: " + catsAverageAge);

        }
    }
}
