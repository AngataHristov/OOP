
namespace Blobs.Models.Interfaces
{
    public interface IBlob : IUnit
    {
        IAttack Attack { get; }

        IBehavior Behavior { get; }

        int TurnsCounter { get; }

        void Update();
    }
}
