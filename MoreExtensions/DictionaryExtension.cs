using System;
using System.Collections.Generic;

namespace MoreExtensions
{
    /// <summary>
    /// Dictionary Extensions
    /// </summary>
    public static class DictionaryExtension
    {
        /// <summary>
        /// Add or Replace a value in a dictionary.
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="value">Value</param>
        public static void AddOrReplace<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, TValue value)
        {
            if (dictionary.ContainsKey(key))
            {
                dictionary[key] = value;
            }
            else
            {
                dictionary.Add(key, value);
            }
        }

        /// <summary>
        /// Returns the value or default against a key from the dictionary.
        /// </summary>
        /// <param name="key">Key</param>
        /// <returns>Value</returns>
        public static TValue GetValueOrDefault<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key)
        {
            return dictionary.ContainsKey(key)
                ? (TValue)Convert.ChangeType(dictionary[key], typeof(TValue)) 
                : default(TValue);
        }
    }
}
