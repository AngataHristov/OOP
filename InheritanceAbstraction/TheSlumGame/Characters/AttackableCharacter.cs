
namespace TheSlum.Characters
{
    using System;

    using TheSlum.Interfaces;
    using Items;

    public abstract class AttackableCharacter : AdvancedCharacter, IAttack
    {
        protected AttackableCharacter(string id, int x, int y, int healthPoints, int defensePoints, Team team, int range)
            : base(id, x, y, healthPoints, defensePoints, team, range)
        {

        }

        public int AttackPoints { get; set; }

        protected override void ApplyItemEffects(Item item)
        {
            base.ApplyItemEffects(item);
            this.AttackPoints += item.AttackEffect;
        }

        protected override void RemoveItemEffects(Item item)
        {
            base.RemoveItemEffects(item);
            this.AttackPoints -= item.AttackEffect;
        }

        public override string ToString()
        {
            return base.ToString() + ", Attack: " + this.AttackPoints;
        }
    }
}
