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

        [Test]
        public void should_sum_numbers_by_Each()
        {
            int sum = 0;
            new []{1, 2, 3}.Each(o => sum += o);
            Assert.AreEqual(6, sum);
        }

        [Test]
        public void should_sum_numbers_by_Inject()
        {
            var expected = new[] {1, 2, 3}.Inject(0, (s, v) => s += v);
            Assert.AreEqual(6, expected);
        }

        [Test]
        public void should_join_strings()
        {
            var expected = new[] {"a", "b", "c"}.Join();
            Assert.AreEqual("abc", expected);
        }

        [Test]
        public void should_join_numbers()
        {
            var expected = new[] { 1, 2, 3 }.Join();
            Assert.AreEqual("123", expected);
        }

        [Test]
        public void should_be_empty_string_for_empty_array()
        {
            var expected = new int[] {}.Join();
            Assert.AreEqual("", expected);
        }
    }
}
