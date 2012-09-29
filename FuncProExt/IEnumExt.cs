using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuncProExt
{
    public static class IEnumExt
    {
        public static void Each<T>(this IEnumerable<T> e, Action<T> f)
        {
            foreach (var o in e) f(o);
        }

        public static IEnumerable<K> Map<T, K>(this IEnumerable<T> e, Func<T, K> f)
        {
            return e.Select(f);
        }

        public static K Inject<T, K>(this IEnumerable<T> e, K initVal, Func<K, T, K> f)
        {
            return e.Aggregate(initVal, f);
        } 

        public static string Join<T>(this IEnumerable<T> e, string separator = "")
        {
            return !e.Any() ? "" : e.Skip(1).Inject(e.First().ToString(), (s, v) => s += v.ToString());
        }
    }
}
