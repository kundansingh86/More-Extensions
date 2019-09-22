using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace MoreExtensions
{
    /// <summary>
    /// Enum Extensions
    /// </summary>
    public static class EnumExtension
    {
        /// <summary>
        /// Get description of an enum
        /// </summary>
        /// <returns>String</returns>
        public static string GetDescription(this Enum value) 
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            var attributes = fi.GetCustomAttributes<DescriptionAttribute>(false);

            if (attributes.IsNotNullOrEmpty())
            {
                return attributes.First().Description;
            }
            else
            {
                return Convert.ToString(value);
            }           
        }
    }
}
