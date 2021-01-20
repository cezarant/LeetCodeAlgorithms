using leetCode.Problems;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;


[TestClass]
public class validAnagramUT
{
    [TestMethod]
    public void doIt()
    {
        validAnagramProblem.implementation("anagram", "nagaram").Should().Be(true);       
        validAnagramProblem.implementation("", "number").Should().Be(false);       
        validAnagramProblem.implementation("number", "").Should().Be(false);        
    }
}

