using NUnit.Framework;
using FuncProExt;

namespace FuncProExtTest
{
    [TestFixture]
    public class IntExtTest
    {
        [Test]
        public void should_3_times()
        {
            const int anyInt = 3;
            var count = 0;

            var result = anyInt.Times(() => { count++; });
            
            result.should_be(anyInt);
            count.should_be(anyInt);
        }

        [Test]
        public void should_3_times_and_inject_index_into_lambda()
        {
            const int anyInt = 3;
            var count = 0;

            var result = anyInt.Times(i => { count += i; });

            result.should_be(anyInt);
            count.should_be(6);
        }
    }
}
