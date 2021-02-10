using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;

namespace TestLeetCodeAlgorithms.UnitTests.Arrays
{    
    [TestClass]
    public class rightRotationUT
    {        
        [TestMethod]
        public void doIt()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 ,8 ,9 , 10};
            int keyRotation = 3;
            int[] output = { 8, 9, 10, 1, 2, 3, 4, 5, 6, 7 };
        }
    }
}
