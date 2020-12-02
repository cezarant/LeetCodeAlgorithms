using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsLeetCode
{
    [TestClass]
    public class reverseStringUnitTest
    {
        [TestMethod]
        public void testReverseString()
        {               
            verifyReverseString("cezar", "razec");
            verifyReverseString("banana", "ananab");
            verifyReverseString("123456789123", "123987654321");
            verifyReverseString("","");
        }
        private void verifyReverseString(string input,string vs_expected)
        {
            char[] output = reverseString.reverseStringMethod(input.ToCharArray());
            char[] expected = vs_expected.ToCharArray();
            output.Should().BeEquivalentTo(expected);
        }        
    }
}
