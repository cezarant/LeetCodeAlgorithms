using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions; 

namespace TestLeetCodeAlgorithms.UnitTests.geekForGeek
{   
    [TestClass]
    public class arrayRotationUT
    {        
        [TestMethod]
        public void doIt()
        {
            int[] arr = new int[]{ 1, 2, 3, 4, 5, 6, 7 };
            int[] expected = new int[] {3,4,5,6,7,1,2 };
            expected.Should().Equal(arr);
        }
    }
}
