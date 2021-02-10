using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;

namespace TestLeetCodeAlgorithms.UnitTests.arrays
{    
    [TestClass]
    public class multipleLeftArrayUT
    {
        [TestMethod]
        public void doIT()
        {
            int[] arr = { 1, 3, 5, 7, 9 };
            int[] keys = { 1, 3, 4, 6 };
            List<int[]> lstOutput = new List<int[]>();
            lstOutput.Add(new int[] { 3, 5 ,7, 9, 1 });
            lstOutput.Add(new int[] { 7, 9, 1, 3, 5 });
            lstOutput.Add(new int[] { 9, 1, 3, 5, 7 });
            lstOutput.Add(new int[] { 3, 5, 7, 9, 1 });
        }
    }
}
