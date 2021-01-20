using ConsoleApp1.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace TestLeetCodeAlgorithms.UnitTests
{
    
    [TestClass]
    public class isPalindromeUT
    {
        [TestMethod]
        public void doIt()
        {
            bool result = IsPalindromeProblem.implementation("A man, a plan, a canal: Panama");
            result.Should().Be(true);

            result = IsPalindromeProblem.implementation("race a car");
            result.Should().Be(false);


        }
    }
}
