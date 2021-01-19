using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;


[TestClass]
public class validAnagramUT
{
    [TestMethod]
    public void doIt()
    {
        bool validAnagram = validAnagramProblem.implementation("anagram", "nagaram");
        validAnagram.Should().Be(true);

        validAnagram = validAnagramProblem.implementation("", "number");
        validAnagram.Should().Be(false);

        validAnagram = validAnagramProblem.implementation("number", "");
        validAnagram.Should().Be(false);
    }
}

