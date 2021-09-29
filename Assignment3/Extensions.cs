using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BDSA2021.Assignment03
{
    public static class Extensions
    {
        public static IEnumerable<T> Flatten<T>(this IEnumerable<T>[] lists)
        {
            foreach (var list in lists)
            {
                foreach (var item in list)
                {
                    yield return item;
                }
            }
        }

        public static IEnumerable<T> Filter<T>(this IEnumerable<T> items, Predicate<T> predicate)
        {
            foreach (var item in items)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }

        public static bool IsSecure(this Uri uri)
        {
            return uri.Scheme == "https";
        }

        public static int WordCount(this string s)
        {
            return Regex.Split(s, @"[^a-zA-Z]+").Length;
        }
    }
}
