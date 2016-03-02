
namespace Blobs.Core
{
    using System;
    using Commands;
    using Enumerations;
    using Interfaces;
    public class CommandManager : ICommandManager
    {
        public IEngine Engine { get; set; }

        public IExecutable ManageCommand(string[] inputArgs)
        {
            IExecutable command = null;

            string commandType = inputArgs[0];

            switch (commandType)
            {
                case "create":
                    command = new CreateCommand(this.Engine, inputArgs[1], int.Parse(inputArgs[2]), int.Parse(inputArgs[3]),
                        (BehaviorTypes)Enum.Parse(typeof(BehaviorTypes), inputArgs[4]), (AttackTypes)Enum.Parse(typeof(AttackTypes), inputArgs[5]));
                    break;
                case "attack":
                    command = new AttackCommand(this.Engine, inputArgs[1], inputArgs[2]);
                    break;
                case "pass":
                    command = new PassCommand();
                    break;
                case "status":
                    command = new StatusCommand(this.Engine);
                    break;
                case "drop":
                    command = new DropCommand();
                    break;
            }

            return command;
        }
    }
}
