using ConsoleApp1.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions; 

namespace TestLeetCodeAlgorithms.UnitTests
{  
  [TestClass]
  public class containDuplicateUT
  {
    [TestMethod]
    public void doIt()
    {
      containsDuplicateProblem.implementation(new int[] { 1, 2, 3, 1 }).Should().Be(true);
      containsDuplicateProblem.implementation(new int[] { 1, 2, 3, 4 }).Should().Be(false);
      containsDuplicateProblem.implementation(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }).Should().Be(true);
    }
  }
}
