
namespace Blobs.Models.Attacks
{
    using System;
    using Enumerations;
    using Interfaces;

    public abstract class Attack : IAttack
    {
        public Attack(int damage, AttackTypes types)
        {
            this.Damage = damage;
            this.Types = types;
        }

        public int Damage { get; }

        public AttackTypes Types { get; }
    }
}
