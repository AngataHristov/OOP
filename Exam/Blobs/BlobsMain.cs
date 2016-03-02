
namespace Blobs
{
    using System;

    using Core;
    using Core.Engine;
    using Core.IO;
    using Interfaces;

    public class BlobsMain
    {
        public static void Main()
        {
            IDataBase db = new DataBase();

            ICommandManager commandManager = new CommandManager();

            IInputReader reader = new ConsoleReader();

            IOutputWriter writer = new ConsoleWriter
            {
                AutoFlush = true
            };

            IEngine engine = new BlobsEngine(db, commandManager, reader, writer);

            engine.Run();
        }
    }
}
