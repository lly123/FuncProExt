using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FuncProExtTest
{
    public static class TestExt
    {
        public static void should_be(this int o, int expected)
        {
            Assert.AreEqual(expected, o);
        }
    }
}
