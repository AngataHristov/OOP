
namespace Blobs.Core.Commands
{
    using Interfaces;

    public class StatusCommand : CommandAbstract
    {
        public StatusCommand(IEngine engine)
            : base(engine)
        {

        }

        public override void Execute()
        {
            foreach (var blob in this.Engine.DB.AllBlobs)
            {
                if (blob.Health > 0)
                {
                    this.Engine.Writer.Write(blob.ToString());
                }
                else
                {
                    this.Engine.Writer.Write(string.Format("Blob {0} KILLED", blob.Name));
                }
            }
        }
    }
}

