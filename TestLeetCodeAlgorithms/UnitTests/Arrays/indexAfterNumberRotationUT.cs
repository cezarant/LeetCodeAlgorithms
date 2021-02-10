using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestLeetCodeAlgorithms.UnitTests.Arrays
{    
    [TestClass]
    public class indexAfterNumberRotationUT
    {       
        [TestMethod]
        public void TestMethod1()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            List<int[]> ranges = new List<int[]>();
            ranges.Add(new int[] { 0, 2 });
            ranges.Add(new int[] { 0, 3 });
        }
    }
}
