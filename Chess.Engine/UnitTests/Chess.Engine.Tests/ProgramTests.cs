using FluentAssertions;
using NUnit.Framework;

namespace Chess.Engine.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        [SetUp]
        public void SetUp()
        {
            _program = new Program();
        }

        private Program _program;

        [Test]
        public void ShouldMultiplyCorrectly()
        {
            _program.CalculateTotal(3).Should().Be(27);
        }
    }
}