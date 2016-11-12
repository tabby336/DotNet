using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebFormsProject;
using FluentAssertions;

namespace WebFormsProjectTests
{
    [TestClass]
    public class ComputeTests
    {
        [TestMethod]
        public void When_ComputeSumIsCalledWithCorrectArguments_Then_ShouldReturnSumAsString()
        {
            ComputeAlgorithm computeSum = new ComputeAlgorithm("2", "1.4", "5");
            computeSum.ComputeSum().Should().Be("8.4");
        }

        [TestMethod]
        public void When_ComputeSumIsCalledWithIncorrectArguments_Then_ShouldReturnSumAsString()
        {
            ComputeAlgorithm computeSum = new ComputeAlgorithm("2", "1.4", "wroong");
            computeSum.ComputeSum().Should().Be("You provided noise.");
        }

    }
}
