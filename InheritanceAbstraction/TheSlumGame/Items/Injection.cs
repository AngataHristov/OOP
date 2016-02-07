
namespace TheSlum.Items
{
    using System;

    using TheSlum.Interfaces;

    public class Injection : Bonus, ITimeoutable
    {
        private const int HealthEffectDefault = 200;
        private const int DefenceEffectDefault = 0;
        private const int AttackEffectDefault = 0;
        private const int TimeOutTurns = 3;

        public Injection(string id)
            : base(id, HealthEffectDefault, DefenceEffectDefault, AttackEffectDefault)
        {
            this.Timeout = TimeOutTurns;
            this.Countdown = TimeOutTurns;
        }
    }
}
