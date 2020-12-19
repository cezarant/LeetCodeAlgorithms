using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;


[TestClass]
public class FizzBuzzUT
{
    [TestMethod]
    public void doIt()
    {
        List<string> lstFizzBuzz = fizzBuzzProblem.implementation(15);
        verify(lstFizzBuzz, new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" });
    }
    public void verify(IList lstFizzBuzz, string[] vetExpected)
    {
        IList<string> lstExpected = new List<string>();
        for (int i = 0; i < vetExpected.Length; i++)
        {
            lstExpected.Add(vetExpected[i]);
        }
        lstFizzBuzz.Should().BeEquivalentTo(lstExpected);
    }
}

