using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsLeetCode
{
    [TestClass]
    public class reverseStringUnitTest
    {
        [TestMethod]
        public void doIt()
        {
            verifyIt("cezar", "razec");
            verifyIt("banana", "ananab");
            verifyIt("123456789123", "123987654321");
            verifyIt("", "");
        }
        private void verifyIt(string input, string vs_expected)
        {
            char[] output = reverseStringProblem.implementation(input.ToCharArray());
            char[] expected = vs_expected.ToCharArray();
            output.Should().BeEquivalentTo(expected);
        }
    }
}
