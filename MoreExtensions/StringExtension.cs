using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace MoreExtensions
{
    /// <summary>
    /// String Extensions
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// Convert a string to "Title Case".
        /// </summary>
        /// <returns>Title Case String</returns>
        public static string ToTitleCase(this string str)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }

        /// <summary>
        /// Check whether a string contains one or more words.
        /// </summary>
        /// <param name="paramArray">Array of words</param>
        /// <returns>boolean</returns>
        public static bool ContainsAny(this string value, params string[] paramArray)
        {
            return paramArray.Any(p => value.ToLower().Contains(p.ToLower()));
        }

        /// <summary>
        /// Check whether a string starts with one or more words.
        /// </summary>
        /// <param name="paramArray">Array of words</param>
        /// <returns>boolean</returns>
        public static bool StartsWithAny(this string value, params string[] paramArray)
        {
            return paramArray.Any(p => value.StartsWith(p, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Check whether a string ends with one or more words.
        /// </summary>
        /// <param name="paramArray">Array of words</param>
        /// <returns>boolean</returns>
        public static bool EndsWithAny(this string value, params string[] paramArray)
        {
            return paramArray.Any(p => value.EndsWith(p, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Trim the string to the given length and add dots(...) after
        /// </summary>
        /// <param name="length">Length to be trimmed</param>
        /// <returns>String</returns>
        public static string TrimLength(this string value, int length)
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length <= length)
                return value;

            return value.Substring(0, length) + "...";
        }

        /// <summary>
        /// Convert a string to its Slug (remove spaces and other special characters)
        /// </summary>
        /// <returns>String</returns>
        public static string ToSlug(this string value)
        {
            string outputStr = "";
            outputStr = value.Trim().Replace(":", "").Replace("&", "").Replace(" ", "-").Replace("'", "").Replace(",", "").Replace("(", "").Replace(")", "").Replace("--", "").Replace(".", "");
            return Regex.Replace(outputStr.Trim().ToLower().Replace("--", ""), "[^a-zA-Z0-9_-]+", "");
        }

        /// <summary>
        /// Strip HTML/XML tags from a string
        /// </summary>
        /// <returns>String</returns>
        public static string StripHtmlTags(this string htmlString)
        {
            if (string.IsNullOrEmpty(htmlString))
                return htmlString;

            return Regex.Replace(htmlString, @"<[^>]+>|&nbsp;", "").Trim();
        }
    }
}
