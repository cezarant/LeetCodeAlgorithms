using ConsoleApp1.Problems;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class majorityElementUT
{
    [TestMethod]
    public void doIt()
    {
        int result = majorityElementProblem.implementation(new int[] { 3, 2, 3 });
        result.Should().Be(3);

        result = majorityElementProblem.implementation(new int[] { 2, 2, 1, 1, 1, 2, 2 });
        result.Should().Be(2);

        string contentFile = System.IO.File.ReadAllText(string.Format(@"{0}\{1}", System.IO.Directory.GetParent(".."), @"TestCases\majoritElement.txt"));
        string[] vetcontent = contentFile.Replace("[", string.Empty).Replace("]", string.Empty).Split(',');
        int[] vectorInput = new int[vetcontent.Length];
        for (int i = 0; i < vectorInput.Length; i++)
            vectorInput[i] = Convert.ToInt32(vetcontent[i]);

        majorityElementProblem.implementation(vectorInput).Should().Be(2);
    }
}

