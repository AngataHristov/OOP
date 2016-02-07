
namespace TheSlum.Items
{
    using System;

    using TheSlum.Interfaces;

    public abstract class Bonus : Item, ITimeoutable
    {
        public Bonus(string id, int healthEffect, int defenseEffect, int attackEffect)
            : base(id, healthEffect, defenseEffect, attackEffect)
        {

        }

        public int Countdown { get; set; }

        public bool HasTimedOut { get; set; }

        public int Timeout { get; set; }
    }
}
