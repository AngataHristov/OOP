
namespace TheSlum.Characters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using TheSlum.Items;
    using TheSlum.Interfaces;

    public class Healer : AdvancedCharacter, IHeal
    {
        private const int HealingPointsDefault = 60;
        private const int DefensePointsDefault = 50;
        private const int HealtPointsDefault = 75;
        private const int RangeDefault = 6;

        public Healer(string id, int x, int y, Team team)
            : base(id, x, y, HealtPointsDefault, DefensePointsDefault, team, RangeDefault)
        {
            this.HealingPoints = HealingPointsDefault;
        }

        public int HealingPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList
                .Where(c => c.Id != this.Id)
                .Where(c => c.Team == this.Team)
                .Where(c => c.IsAlive)
                .OrderBy(c => c.HealthPoints)
                .FirstOrDefault();
        }
    }
}
