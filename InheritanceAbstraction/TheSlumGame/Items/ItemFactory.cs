
namespace TheSlum.Items
{
    using System;

    public static class ItemFactory
    {
        public static Item Create(string itemType, string id)
        {
            switch (itemType.ToLower())
            {
                case "axe":
                    return new Axe(id);
                case "shield":
                    return new Shield(id);
                case "injection":
                    return new Injection(id);
                case "pill":
                    return new Pill(id);
                default:
                    throw new ArgumentException("Invalid item type!");
            }
        }
    }
}
