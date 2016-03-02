
namespace Blobs.Core.Commands
{
    using System;
    using System.Linq;
    using Enumerations;
    using Interfaces;
    using Models.Interfaces;

    public class AttackCommand : CommandAbstract
    {
        private string firstBlobName;
        private string secondBlobName;

        public AttackCommand(IEngine engine, string firstBlobName, string secondBlobName)
            : base(engine)
        {
            this.firstBlobName = firstBlobName;
            this.secondBlobName = secondBlobName;
        }

        public override void Execute()
        {
            var firstBlob = this.Engine.DB.AllBlobs
                .FirstOrDefault(b => b.Name == this.firstBlobName);

            var secondBlob = this.Engine.DB.AllBlobs
               .FirstOrDefault(b => b.Name == this.secondBlobName);

            if (firstBlob == null || secondBlob == null)
            {
                throw new InvalidOperationException(Messages.InvaliOperation);
            }
            else if (!firstBlob.IsAlive)
            {
                throw new InvalidOperationException(string.Format(Messages.NotAliveBlob, firstBlob.Name));
            }
            else
            {
                secondBlob.Health -= firstBlob.Damage;

                if (secondBlob.Health <= 0)
                {
                    secondBlob.Health = 0;
                }

                if (firstBlob.Attack.Types == AttackTypes.Blobplode && secondBlob.Health <= 0)
                {
                    secondBlob.Health = 1;
                }

                if (secondBlob.Health <= 0)
                {
                    secondBlob.Health = 0;
                    secondBlob.IsAlive = false;
                }
            }
        }
    }
}
