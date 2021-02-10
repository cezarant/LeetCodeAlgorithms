using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;


[TestClass]
public class reverseStringUnitTest
{
    [TestMethod]
    public void doIt()
    {
        string vs_path = System.IO.Directory.GetParent("..").ToString();        
        reverseStringProblem.implementation("cezar".ToCharArray()).Should().Equal("razec".ToCharArray());
        
        reverseStringProblem.implementation("banana".ToCharArray()).Should().Equal("ananab".ToCharArray());
        reverseStringProblem.implementation("123456789123".ToCharArray()).Should().Equal("321987654321".ToCharArray());

        string contentFile = System.IO.File.ReadAllText(string.Format(@"{0}\{1}",vs_path, @"TestCases\1.txt"));
        string contentFileReverted = System.IO.File.ReadAllText(string.Format(@"{0}\{1}",vs_path , @"TestCases\1reverted.txt"));
        var conv = reverseStringProblem.implementation(contentFile.ToCharArray());          
        conv.Should().Equal(contentFileReverted.ToCharArray());
        
        reverseStringProblem.implementation("".ToCharArray()).Should().Equal(string.Empty);
    }
}

