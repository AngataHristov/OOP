
namespace Blobs.Models.Interfaces
{
    using Enumerations;

    public interface IBehavior
    {
        BehaviorTypes Types { get; }

        bool IsTriggered { get; set; }
    }
}
