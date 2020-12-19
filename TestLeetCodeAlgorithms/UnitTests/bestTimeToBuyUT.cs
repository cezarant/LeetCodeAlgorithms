using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

[TestClass]
public class bestTimeToBuyUT
{
    [TestMethod]
    public void doIt()
    {
        int result = bestTimeToBuyProblem.implementation(new int[]{ 7, 1, 5, 3, 6, 4 });
        result.Should().Be(5);

        result = bestTimeToBuyProblem.implementation(new int[]{});
        result.Should().Be(0);

        result = bestTimeToBuyProblem.implementation(new int[] {1});
        result.Should().Be(0);
    }
}

