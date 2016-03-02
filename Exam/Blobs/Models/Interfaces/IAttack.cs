
namespace Blobs.Models.Interfaces
{
    using Enumerations;

    public interface IAttack
    {
        int Damage { get; }

        AttackTypes Types { get; }
    }
}
