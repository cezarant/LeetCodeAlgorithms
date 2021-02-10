using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;

namespace TestLeetCodeAlgorithms.UnitTests.arrays
{    
    [TestClass]
    public class findPairWithGivenSumUT
    {        
        [TestMethod]
        public void doIT()
        {
            int[] arr = { 11, 15, 6, 8, 9, 10 };
            int key = 16;
            bool bRetorno = false;
            bRetorno.Should().BeTrue();
        }
    }
}
