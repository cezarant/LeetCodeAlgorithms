using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class MoveZerosUT
{
    [TestMethod]
    public void doIt()
    {
        int[] result = moveZerosProblem.implementation(new int[] { 0, 1, 0, 3, 12 });
        result.Should().BeEquivalentTo(new int[] { 1, 3, 12, 0, 0 });
    }
}

