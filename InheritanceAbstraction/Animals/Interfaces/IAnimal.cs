
namespace AnimalsType.Interfaces
{
    public interface IAnimal : ISoundProducible
    {
        string Name { get; }

        int Age { get; }

        Genders Gender { get; }
    }
}
