

namespace CustomLINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtencion
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Predicate<T> predicate)
        {
            List<T> result = new List<T>();

            foreach (var item in collection)
            {
                if (!predicate(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public static TSelector Max<TSource, TSelector>(this IEnumerable<TSource> collection, Func<TSource, TSelector> condition)
            where TSelector : IComparable<TSelector>
        {
            TSelector max = condition(collection.First());

            if (collection == null)
            {
                throw new InvalidOperationException("Collection is empty!");
            }

            foreach (var item in collection)
            {
                if (max.CompareTo(condition(item)) < 0)
                {
                    max = condition(item);
                }
            }

            return max;
        }
    }
}
