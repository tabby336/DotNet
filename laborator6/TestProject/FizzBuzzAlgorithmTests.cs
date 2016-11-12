
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using WebFormsProject;

namespace TestProject
{
    [TestClass]
    public class FizzBuzzAlgorithmTests
    {
        [TestMethod]
        public void When_FizzBuzzIsInstanciatedCorrectly_ShouldReturnFizzBuzzString()
        {
            string fizzbuzzString = CreateSut("5");
            fizzbuzzString.Should().Be("12Fizz4Buzz");
        }

        [TestMethod]
        public void When_FizzBuzzIsCalledWithNan_Then_ShouldReturnErrorMessage()
        {
            string fizzbuzzString = CreateSut("wroong");
            fizzbuzzString.Should().Be("You provided noise.");
        }

        [TestMethod]
        public void When_FizzBuzzIsCalledWithBigNumber_Then_ShouldReturnErrorMessage()
        {
            string fizzbuzzString = CreateSut("1000");
            fizzbuzzString.Should().Be("Not the best number ever.");
        }
        private string CreateSut(string num)
        {
            FizzBuzzAlgorithm fizzbuzz = new FizzBuzzAlgorithm(num);
            return fizzbuzz.GetFizzBuzz();
        }
    }
}
