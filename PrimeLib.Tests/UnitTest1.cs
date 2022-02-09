using System;
using FluentAssertions;
using NUnit.Framework;

namespace PrimeLib.Tests
{
    public class Tests
    {
        [TestCase(0, false)]
        [TestCase(1, false)]
        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(4, false)]
        [TestCase(5, true)]
        public void CheckIfPrime_IntegerValue_ReturnsIsPrime(int value, bool expectedValue)
        {
            var actualValue = PrimeLib.CheckIfPrime(value);
            actualValue.Should().Be(expectedValue);
        }

        [Test]
        public void CheckIfPrime_NegativeValue_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => PrimeLib.CheckIfPrime(-5));
        }
    }
}