using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions; 

namespace TestLeetCodeAlgorithms.UnitTests.geekForGeek
{    
    [TestClass]
    public class searchPivotedArrayUT
    {
        [TestMethod]
        public void doIt()
        {
            int[] arr = { 5, 6, 7, 8, 9, 10, 1, 2, 3 };
            int key = 3;
            key.Should().Be(8);

            arr = new int[]{ 5, 6, 7, 8, 9, 10, 1, 2, 3 };
            key = 30;
            key.Should().Be(-1);
        }
    }
}
