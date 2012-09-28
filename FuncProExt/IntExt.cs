using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuncProExt
{
    public static class IntExt
    {
        public static int times(this int o, Action f)
        {
            for (int i = 1; i <= o; i++) f();
            return o;
        }

        public static int times(this int o, Action<int> f)
        {
            for (int i = 1; i <= o; i++) f(i);
            return o;
        }
    }
}
