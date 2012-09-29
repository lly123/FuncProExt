using Moq;
using NUnit.Framework;
using FuncProExt;

namespace FuncProExtTest
{
    [TestFixture]
    class StringExtTest
    {
        [Test]
        public void should_convert_strings_in_array_to_upper_case()
        {
            var expected = new []{"a", "b", "c"}.Map("ToUpper".f<string>());
            Assert.AreEqual(new []{"A", "B", "C"}, expected);
        }

        [Test]
        public void should_call_specific_method_by_method_name()
        {
            var mock = new Mock<AnyClass>();
            mock.Setup(o => o.AnyMethod());

            var objectArray = new[] {mock.Object};
            objectArray.Each("AnyMethod".a<AnyClass>());

            mock.VerifyAll();
        }
    }

    public class AnyClass
    {
        public virtual void AnyMethod() {}
    }
}
