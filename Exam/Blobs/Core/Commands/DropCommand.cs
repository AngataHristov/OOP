
namespace Blobs.Core.Commands
{
    using System;
    using Events;
    using Interfaces;

    public class DropCommand : CommandAbstract
    {
        public DropCommand()
            : base(null)
        {

        }

        public override void Execute()
        {
            OnExecute(new CommandEventArgs() { Stopped = true });
        }
    }
}
