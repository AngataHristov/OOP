
namespace Blobs.Core.Factories
{
    using System;

    using Enumerations;
    using Models.Behaviors;
    using Models.Interfaces;

    public static class BehaviorFactory
    {
        public static IBehavior Create(BehaviorTypes type)
        {
            return new Behavior(type);
        }
    }
}
