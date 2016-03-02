
namespace Blobs.Core.Factories
{
    using System;

    using Enumerations;
    using Models.Attacks;
    using Models.Behaviors;
    using Models.Interfaces;
    using Models.Units;

    public static class BlobFactory
    {
        public static IBlob Create(string name, int health, int damage, BehaviorTypes behavior, AttackTypes attack)
        {
            int blobHealth = health;

            int attackDamage = new int();

            if (attack == AttackTypes.PutridFart)
            {
                attackDamage = damage;
            }
            else if (attack == AttackTypes.Blobplode)
            {
                attackDamage = 2 * damage;
            }

            IAttack blobAttack = AttackFactory.Create(attackDamage, attack);

            IBehavior blobBehavior = BehaviorFactory.Create(behavior);

            return new Blob(name, blobHealth, damage, blobAttack, blobBehavior);          
        }
    }
}
