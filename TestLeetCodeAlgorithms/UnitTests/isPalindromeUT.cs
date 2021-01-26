using ConsoleApp1.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace TestLeetCodeAlgorithms.UnitTests
{  
  [TestClass]
  public class isPalindromeUT
  {
    [TestMethod]
    public void TestMethod1()
    {
        IsPalindromeProblem.implementation("A man, a plan, a canal: Panama").Should().Be(true);
        IsPalindromeProblem.implementation("race a car").Should().Be(false);
    }
  }
}
