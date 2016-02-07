
namespace TheSlum.Items
{
    using System;

    using TheSlum.Interfaces;

    public class Pill : Bonus, ITimeoutable
    {
        private const int HealthEffectDefault = 0;
        private const int DefenceEffectDefault = 0;
        private const int AttackEffectDefault = 100;
        private const int TimeOutTurns = 1;

        public Pill(string id)
            : base(id, HealthEffectDefault, DefenceEffectDefault, AttackEffectDefault)
        {
            this.Timeout = TimeOutTurns;
            this.Countdown = TimeOutTurns;
        }
    }
}
