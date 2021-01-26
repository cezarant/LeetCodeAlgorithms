using ConsoleApp1.Problems;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class isPalindromeUT
{
    [TestMethod]
    public void doIt()
    {
        IsPalindromeProblem.implementation("A man, a plan, a canal: Panama").Should().Be(true);
        IsPalindromeProblem.implementation("race a car").Should().Be(false);
    }
}