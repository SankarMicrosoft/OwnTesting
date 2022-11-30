using HelloWorldProgram;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace OwnTesting
{
    [TestClass]
    public class UnitTest1
    {
        private const string ExpectedMatch = "Hello World";
        private const string ExpectedMismatch = "Hello World!";
        [TestMethod]
        public void TestMethodMatch()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                HWProgram.Main();
                var result = sw.ToString().Trim();
                Assert.AreEqual(ExpectedMatch, result);
            }
        }
        [TestMethod]
        public void TestMethodMismatch()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                HWProgram.Main();
                var result = sw.ToString().Trim();
                Assert.AreNotEqual(ExpectedMismatch, result);
            }
        }
    }
}