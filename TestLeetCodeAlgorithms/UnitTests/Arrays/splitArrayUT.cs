using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;

namespace TestLeetCodeAlgorithms.UnitTests.Arrays
{    
    [TestClass]
    public class splitArrayUT
    {        
        [TestMethod]
        public void doIt()
        {
            int[] arr = { 12, 10, 5, 6, 52, 36 };
            int k = 2;
            int[] output = { 5, 6, 52, 36, 12, 10 };
        }
    }
}
