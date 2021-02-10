using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;

namespace TestLeetCodeAlgorithms.UnitTests.Arrays
{    
    [TestClass]
    public class leftRightCircularUT
    {        
        [TestMethod]
        public void doIt()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            List<int[]> queries = new List<int[]>();            
            List<int> lstOutput = new List<int>();
            queries.Add(new int[] { 1, 3 });
            queries.Add(new int[] { 3, 0, 2 });
            queries.Add(new int[] { 2, 1 });
            queries.Add(new int[] { 3, 1, 4 });

            lstOutput.Add(12);
            lstOutput.Add(11);
        }
    }
}
