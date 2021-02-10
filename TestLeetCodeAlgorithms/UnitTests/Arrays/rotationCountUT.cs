using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;

namespace TestLeetCodeAlgorithms.UnitTests.arrays
{    
    [TestClass]
    public class rotationCountUT
    {        
        [TestMethod]
        public void doIT()
        {
            int[] arr = { 15, 18, 2, 3, 6, 12 };
            int output = 2;
            output.Should().Be(2);
        }
    }
}
