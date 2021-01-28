using NUnit.Framework;
using NUnitTesting;
using ASCIIpe_the_room;

namespace NUnitTesting.Tests
{
    [TestFixture]
    public class Tests
    {
        private FirstTest _FirstTest;

        [SetUp]
        public void Setup()
        {
            _FirstTest = new();
        }

        [Test]
        public void IsDirNull()
        {
            var result = _FirstTest.DirArrayShould(Program.IntToDirections(1));

            Assert.IsFalse(result, "DirArray should not be null");
        }

    }


}
