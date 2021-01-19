using ConsoleApp1.Problems;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class findNumberUT
{
    [TestMethod]
    public void doIt()
    {
        int output = findNumberProblem.implementation(new int[] { 12, 345, 2, 6, 7896 });
        output.Should().Be(2);

        output = findNumberProblem.implementation(new int[] { 555, 901, 482, 1771 });
        output.Should().Be(1);
    }
}

