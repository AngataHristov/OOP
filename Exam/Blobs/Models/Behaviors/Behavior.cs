
namespace Blobs.Models.Behaviors
{
    using System;
    using Enumerations;
    using Interfaces;

    public class Behavior : IBehavior
    {
        public Behavior(BehaviorTypes types)
        {
            this.Types = types;
            this.IsTriggered = false;
        }

        public BehaviorTypes Types { get; }

        public bool IsTriggered { get; set; }
    }
}
