using ConsoleApp1.Problems;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLeetCodeAlgorithms.UnitTests
{
    [TestClass]
    public class missingNumberUT
    {
        [TestMethod]
        public void doIt()
        {
            missingNumberProblem.implementation(new int[] { 3, 0, 1 }).Should().Be(2);
            missingNumberProblem.implementation(new int[] { 0, 1 }).Should().Be(2);
            missingNumberProblem.implementation(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }).Should().Be(8);
            missingNumberProblem.implementation(new int[] { 0 }).Should().Be(1);
        }
    }
}
