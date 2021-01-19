using ConsoleApp1.Problems;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class climbimgStairsUT
{
    [TestMethod]
    public void doIt()
    {
        int n = climbingStairsProblem.implementation(2);
        n.Should().Be(2);

        n = climbingStairsProblem.implementation(3);
        n.Should().Be(3);
    }
}

