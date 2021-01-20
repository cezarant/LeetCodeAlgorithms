using ConsoleApp1.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace TestLeetCodeAlgorithms.UnitTests
{    
    [TestClass]
    public class validParentesisUT
    {
        [TestMethod]
        public void doIt()
        {
            validParentesisProblem.implementation("()").Should().BeTrue();
            validParentesisProblem.implementation("()[]{}").Should().BeTrue();
            validParentesisProblem.implementation("(]").Should().BeFalse();
            validParentesisProblem.implementation("([)]").Should().BeFalse();
            validParentesisProblem.implementation("{[]}").Should().BeTrue();
        }
    }
}
