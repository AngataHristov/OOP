
namespace Blobs.Core.Factories
{
    using System;

    using Enumerations;
    using Models.Attacks;
    using Models.Behaviors;
    using Models.Interfaces;

    public static class AttackFactory
    {
        public static IAttack Create(int damage, AttackTypes type)
        {
            var attackType = type;
            var attackDamage = damage;

            switch (attackType)
            {
                case AttackTypes.Blobplode:
                    return new BlobplodeAttack(attackDamage, attackType);
                case AttackTypes.PutridFart:
                    return new PutridFartAttack(attackDamage, attackType);
                default:
                    throw new NotSupportedException("Invalid type supplied");
            }
        }
    }
}
