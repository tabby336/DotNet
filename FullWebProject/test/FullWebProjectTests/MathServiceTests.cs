using FullWebProject.Services;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FullWebProjectTests
{
    [TestClass]
    public class MathServiceTests
    {
      [TestMethod]
      public void When_AddNumbersIsCalled_Then_ShouldReturnSum()
      {
          MathService mathService = CreateSut();
          mathService.AddNumbers(1,2,3).Should().Be(6);
          mathService.AddNumbers().Should().Be(0);
      }

      [TestMethod]
      public void When_MultiplyNumbersIsCalled_Then_ShouldReturnProduct()
      {
          MathService mathService = CreateSut();
          mathService.MultiplyNumbers(1,2,3).Should().Be(6);
          mathService.MultiplyNumbers().Should().Be(1);
      }

      private MathService CreateSut()
      {
          MathService mathService = new MathService();
          return mathService;
      }
    }
}
