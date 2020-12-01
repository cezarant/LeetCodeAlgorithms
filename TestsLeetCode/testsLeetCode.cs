using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsLeetCode
{
    [TestClass]
    public class testsLeetCode
    {
        [TestMethod]
        public void testTwoSum()
        {

            leetCodeAlgorithms vo_leetCodeAlg = new leetCodeAlgorithms();
            int[] output = vo_leetCodeAlg.twoSum(new int[] { 2, 7, 11, 15 }, 9);
            int[] result = new int[] { 0, 1 };

            output.Should().BeEquivalentTo(result);

            output = vo_leetCodeAlg.twoSum(new int[] { 3, 2, 4 }, 6);
            result = new int[] { 1, 2 };
            output.Should().BeEquivalentTo(result);

            output = vo_leetCodeAlg.twoSum(new int[] { 3, 3 }, 6);
            result = new int[] { 0, 1 };
            output.Should().BeEquivalentTo(result);

            output = vo_leetCodeAlg.twoSum(new int[] { 3,2, 3 }, 6);
            result = new int[] { 0, 2 };
            output.Should().BeEquivalentTo(result);


            output = vo_leetCodeAlg.twoSum(new int[] { 2, 5, -70, 0, 35, 41, 4, 4, 26, 29, 56, 21, -19, 38, 31, 33, 37, 39, -46, 65, 71, 68 }, 70);
            result = new int[] { 15, 16 };
            output.Should().BeEquivalentTo(result);
        }
    }
}
