using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsLeetCode
{
    [TestClass]
    public class twoSumUnitTest
    {
        [TestMethod]
        public void doIt()
        {
            verifyIt(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 });

            verifyIt(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 });

            verifyIt(new int[] { 3, 3 }, 6, new int[] { 0, 1 });

            verifyIt(new int[] { 3, 2, 3 }, 6, new int[] { 0, 2 });

            verifyIt(new int[] { 2, 5, -70, 0, 35, 41, 4, 4, 26, 29, 56, 21, -19, 38, 31, 33, 37, 39, -46, 65, 71, 68 }, 70, new int[] { 0, 21 });

            verifyIt(new int[] { 2, 5, -70, 0, 35, 41, 4, 4, 26, 29, 56, 21, -19, 38, 31, 33, 37, 39, -46, 65, 71, 68 }, 8, new int[] { 6, 7 });

            verifyIt(new int[] { 2, 5, -70, 0, 35, 41, 4, 4, 26, 29, 56, 21, -19, 38, 31, 33, 37, 39, -46, 65, 71, 68 }, -1000, new int[] { 0, 0 });
        }
        private void verifyIt(int[] input, int target, int[] expected)
        {
            int[] output = twoSumProblem.implementation(input, target);
            output.Should().BeEquivalentTo(expected);
        }
    }
}
