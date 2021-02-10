using ConsoleApp1.Problems;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;


[TestClass]
public class containDuplicateUT
{
    [TestMethod]
    public void doIt()
    {
        //containsDuplicateProblem.implementation(new int[] { 4, 2, 3, 4 }).Should().Be(true);
        //containsDuplicateProblem.implementation(new int[] { 1, 2, 3, 4 }).Should().Be(false);
        containsDuplicateProblem.implementation(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11,12}).Should().Be(false);
    }
}

