using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;

namespace TestLeetCodeAlgorithms.UnitTests.Arrays
{    
    [TestClass]
    public class leftRotationUT
    {        
        [TestMethod]
        public void doIt()
        {
            int[] arr = { 1, 3, 5, 7, 9 };
            List<int> lstKey = new List<int>();
            List<int[]> lstOutPut = new List<int[]>(); 
            lstKey.Add(1);
            lstKey.Add(3);
            lstKey.Add(4);
            lstKey.Add(6);
            lstOutPut.Add(new int[] { 3, 5, 7, 9, 1 });
            lstOutPut.Add(new int[] {7, 9, 1, 3, 5 });
            lstOutPut.Add(new int[] {9, 1, 3, 5, 7 });
            lstOutPut.Add(new int[] {3, 5, 7, 9, 1 });
        }
    }
}
