using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Garco10.DataAccess.QLCV.Global
{
    public static class HelperMethods
    {
        public static bool ContainsAll<T>(this IEnumerable<T> containingList, IEnumerable<T> lookupList)
        {
            return !lookupList.Except(containingList).Any();
        }

        public static string TruncateString(string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }

        public static string RemoveDuplicates(string input)
        {
            return new string(input.ToCharArray().Distinct().ToArray());
        }
    }
}
