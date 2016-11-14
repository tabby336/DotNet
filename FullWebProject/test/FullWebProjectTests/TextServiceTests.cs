using FullWebProject.Services;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FullWebProjectTests
{
    [TestClass]
    public class TextServiceTests
    {
      [TestMethod]
      public void When_ConcatIsCalled_Then_ShouldReturnConcatenatedStrings()
      {
          TextService textService = CreateSut();
          textService.ConcatInputs(",", "a", "b").Should().Be("a,b");
          textService.ConcatInputs(",").Should().Be("");
      }

      private TextService CreateSut()
      {
          TextService textService = new TextService();
          return textService;
      }
    }
}
