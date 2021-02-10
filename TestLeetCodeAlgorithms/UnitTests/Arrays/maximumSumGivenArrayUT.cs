using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions; 

namespace TestLeetCodeAlgorithms.UnitTests.arrays
{    
    [TestClass]
    public class maximumSumGivenArrayUT
    {        
        [TestMethod]
        public void doIt()
        {
            int[] arr = { 8, 3, 1, 2 };
            int output = 29;
            output.Should().Be(29);
        }
    }
}
