
namespace Blobs.Models.Interfaces
{
    public interface IUnit
    {
        string Name { get; }

        int Health { get; set; }

        int Damage { get; }

        bool IsAlive { get; set; }
    }
}
