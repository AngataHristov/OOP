
namespace Blobs.Core.Commands
{
    using System;
    using System.Linq;

    using Enumerations;
    using Factories;
    using Interfaces;
    using Models.Interfaces;

    public class CreateCommand : CommandAbstract
    {
        private string name;
        private int health;
        private int damage;
        private BehaviorTypes behavior;
        private AttackTypes attack;

        public CreateCommand(IEngine engine, string name, int health, int damage, BehaviorTypes behavior, AttackTypes attack)
            : base(engine)
        {
            this.name = name;
            this.health = health;
            this.damage = damage;
            this.behavior = behavior;
            this.attack = attack;
        }

        public override void Execute()
        {
            IBlob blob = BlobFactory.Create(this.name, this.health, this.damage, this.behavior, this.attack);

            if (this.Engine.DB.AllBlobs.Any(b => b.Name == this.name))
            {
                throw new ArgumentException(Messages.BlobAlreadyExist);
            }
            else
            {
                this.Engine.DB.AddBlob(blob);
            }
        }
    }
}
