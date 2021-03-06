﻿using ConsoleApp1.Problems;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLeetCodeAlgorithms.UnitTests
{

    [TestClass]
    public class firstUniqueCharacterUT
    {
        [TestMethod]
        public void doIt()
        {
            int result = firstUniqueCharacterProblem.implementation("leetcode");
            result.Should().Be(0);

            result = firstUniqueCharacterProblem.implementation("loveleetcode");
            result.Should().Be(2);
        }
    }
}
