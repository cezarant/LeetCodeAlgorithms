﻿using ConsoleApp1.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;


[TestClass]
public class convertSortedArrayUT
{
    [TestMethod]
    public void doIt()
    {
         TreeNode treeNode = convertSortedArrayBST.implementation(new int[] { -10, -3, 0, 5, 9 });
         treeNode.Should().Be(null);
    }
}

