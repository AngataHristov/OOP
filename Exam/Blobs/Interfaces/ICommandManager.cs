
namespace Blobs.Interfaces
{
   public interface ICommandManager
    {
        IEngine Engine { get; set; }

        IExecutable ManageCommand(string[] inputArgs);
    }
}
