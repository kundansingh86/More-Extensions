using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MoreExtensions
{
    /// <summary>
    /// Collection Extensions
    /// </summary>
    public static class CollectionExtension
    {
        /// <summary>
        /// Iterate a generic collection with an action
        /// </summary>
        /// <param name="action">Action</param>
        public static void ForEach<T>(this IEnumerable<T> array, Action<T> action)
        {
            if (array.IsNotNullOrEmpty())
            {
                foreach (T element in array)
                {
                    action(element);
                }
            }
        }

        /// <summary>
        /// Iterate a non-generic collection with an action
        /// </summary>
        /// <param name="action">Action</param>
        public static void ForEach<T>(this IEnumerable array, Action<T> action)
        {
            array.Cast<T>().ForEach<T>(action);
        }

        /// <summary>
        /// Check whether a collection is neither null and nor empty
        /// </summary>
        /// <returns>Boolean</returns>
        public static bool IsNotNullOrEmpty<T>(this IEnumerable<T> array)
        {
            return array != null && array.Count() > 0;
        }
    }
}
