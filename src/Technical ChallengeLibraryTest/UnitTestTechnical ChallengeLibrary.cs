using NUnit.Framework;

namespace Technical_ChallengeLibraryTest
{
    public class Tests
    {
        private TechnicalChallengeLibrary.Main _main;
        [SetUp]
        public void Setup()
        {
            _main = new TechnicalChallengeLibrary.Main();
        }

        [Test]
        [TestCase(45)]
        public void DiscoverDividingAndPrimeNumbers_ValidNumber_ResultTrue(int number)
        {
            var result = _main.DiscoverDividingAndPrimeNumbers(number);
            Assert.IsTrue(result.Success);
        }
        [Test]
        [TestCase(-1)]
        public void DiscoverDividingAndPrimeNumbers_InvalidNumber_ResultFalse(int number)
        {
            var result = _main.DiscoverDividingAndPrimeNumbers(number);
            Assert.IsFalse(result.Success);
        }
    }
}