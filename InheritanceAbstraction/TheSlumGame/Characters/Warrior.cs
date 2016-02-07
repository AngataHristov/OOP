
namespace TheSlum.Characters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using TheSlum.Items;
    using TheSlum.Interfaces;

    public class Warrior : AttackableCharacter, IAttack
    {
        private const int AttackPointsDefault = 150;
        private const int DefensePointsDefault = 100;
        private const int HealtPointsDefault = 200;
        private const int RangeDefault = 2;

        public Warrior(string id, int x, int y, Team team)
            : base(id, x, y, HealtPointsDefault, DefensePointsDefault, team, RangeDefault)
        {
            this.AttackPoints = AttackPointsDefault;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList.FirstOrDefault(c => c.IsAlive && c.Team != this.Team);
        }
    }
}
