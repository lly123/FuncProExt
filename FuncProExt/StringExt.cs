using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuncProExt
{
    public partial class String
    {
        public static Action<string> operator ~(String s)
        {
            return o => o.ToUpper();
        }
    }
}
