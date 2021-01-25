using leetCode.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace TestLeetCodeAlgorithms.UnitTests
{    
    [TestClass]
    public class validPalindromeUT
    {        
        [TestMethod]
        public void doIt()
        {
            IsPalindromeProblem.implementation("A man, a plan, a canal: Panama").Should().Be(true);
            IsPalindromeProblem.implementation("race a car").Should().Be(false);
        }
    }
}
