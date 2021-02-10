using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions; 

namespace TestLeetCodeAlgorithms.UnitTests.geekForGeek
{    
    [TestClass]
    public class cyclicallyRotateUT
    {        
        [TestMethod]
        public void doIt()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int[] expected = new int[] { 5, 1, 2 , 3, 4};
            expected.Should().Equal(arr);
        }
    }
}
