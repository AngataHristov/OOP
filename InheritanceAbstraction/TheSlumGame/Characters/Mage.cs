
namespace TheSlum.Characters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using TheSlum.Items;
    using TheSlum.Interfaces;

    public class Mage : AttackableCharacter, IAttack
    {
        private const int AttackPointsDefault = 300;
        private const int DefensePointsDefault = 50;
        private const int HealtPointsDefault = 150;
        private const int RangeDefault = 5;

        public Mage(string id, int x, int y, Team team)
            : base(id, x, y, HealtPointsDefault, DefensePointsDefault, team, RangeDefault)
        {
            this.AttackPoints = AttackPointsDefault;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList.LastOrDefault(c => c.IsAlive && c.Team != this.Team);
        }
    }
}
