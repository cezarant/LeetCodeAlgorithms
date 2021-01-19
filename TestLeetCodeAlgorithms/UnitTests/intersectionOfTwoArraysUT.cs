using ConsoleApp1.Problems;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class intersectionOfTwoArraysUT
{
    [TestMethod]
    public void doIt()
    {
        int[] nums = intersectionOfTwoArraysProblem.implementation(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 });
        nums.Should().BeEquivalentTo(2);

        nums = intersectionOfTwoArraysProblem.implementation(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 });
        nums.Should().BeEquivalentTo(9, 4);
    }
}

