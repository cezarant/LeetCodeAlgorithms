using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;


[TestClass]
public class reverseStringUnitTest
{
    [TestMethod]
    public void doIt()
    {
        reverseStringProblem.implementation("cezar".ToCharArray()).Should().Equal("razec".ToCharArray());
        reverseStringProblem.implementation("banana".ToCharArray()).Should().Equal("ananab".ToCharArray());
        reverseStringProblem.implementation("123456789123".ToCharArray()).Should().Equal("321987654321".ToCharArray());

        string contentFile = System.IO.File.ReadAllText(string.Format(@"{0}\{1}", System.IO.Directory.GetParent(".."), @"TestCases\1.txt"));
        string contentFileReverted = System.IO.File.ReadAllText(string.Format(@"{0}\{1}", System.IO.Directory.GetParent(".."), @"TestCases\1reverted.txt"));
        reverseStringProblem.implementation(contentFile.ToCharArray()).Should().Equal(contentFileReverted.ToCharArray());
        
        reverseStringProblem.implementation("".ToCharArray()).Should().Equal(string.Empty);
    }
}

