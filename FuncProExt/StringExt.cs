using System;

namespace FuncProExt
{
    public static class StringExt
    {
        public static Func<T, object> f<T>(this String s)
        {
            var typeOfT = typeof(T);
            var methodOfNamingS = typeOfT.GetMethod(s, new Type[] { });
            return o => methodOfNamingS.Invoke(o, new object[] { });
        }
        
        public static Func<T, K> f<T, K>(this String s, K kClass)
        {
            var typeOfT = typeof(K);
            var methodOfNamingS = typeOfT.GetMethod(s, new Type[] { });
            return o => (K)methodOfNamingS.Invoke(o, new object[] { });
        }

        public static Action<T> a<T>(this String s)
        {
            var typeOfT = typeof(T);
            var methodOfNamingS = typeOfT.GetMethod(s, new Type[] {});
            return o => methodOfNamingS.Invoke(o, new object[] {});
        }
    }
}
