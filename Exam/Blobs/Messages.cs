using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blobs
{
    public static class Messages
    {
        public const string InvalidCommand = "Invalid command!";
        public const string InvalidNameArguments = "Name cannot be null or empty";
        public const string InvalidHealthArguments = "Health cannot be negative";
        public const string InvalidDamageArguments = "Damage cannot be negative";
        public const string InvalidAttackArguments = "Attack cannot be null";
        public const string InvalidBehaviorArguments = "Behavior cannot be null";

        public const string BlobAlreadyExist = "Blob with the same name already exist";
        public const string InvaliOperation = "One of the blobs doesn't exist";
        public const string NotAliveBlob = "Blob {0} is dead and cannot attack";
    }
}
