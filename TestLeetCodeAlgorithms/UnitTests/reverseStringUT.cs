using leetCode.Problems;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class reverseStringUT
{
    [TestMethod]
    public void doIt()
    {
        reverseStringProblem.implementation("cezar".ToCharArray()).Should().BeEquivalentTo("razec");
        reverseStringProblem.implementation("banana".ToCharArray()).Should().BeEquivalentTo("ananab");
        reverseStringProblem.implementation("123456789123".ToCharArray()).Should().BeEquivalentTo("123987654321");
        reverseStringProblem.implementation("".ToCharArray()).Should().BeEquivalentTo("");
        reverseStringProblem.implementation(new char[]{}).Should().BeEquivalentTo(new char[]{});
    }    
}

