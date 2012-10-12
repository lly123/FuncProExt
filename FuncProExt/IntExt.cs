using System;

namespace FuncProExt
{
    public static class IntExt
    {
        public static int Times(this int o, Action f)
        {
            for (int i = 1; i <= o; i++) f();
            return o;
        }

        public static int Times(this int o, Action<int> f)
        {
            for (int i = 1; i <= o; i++) f(i);
            return o;
        }
    }
}
