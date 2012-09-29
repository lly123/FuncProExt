using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using FuncProExt;

namespace FuncProExtTest
{
    [TestFixture]
    class IEnumExtTest
    {
        [Test]
        public void should_add_1_for_each_number_in_array()
        {
            var expected = new []{1, 2, 3}.Map(o => o + 1);
            Assert.AreEqual(new []{2, 3, 4}, expected);
        }
    }
}
