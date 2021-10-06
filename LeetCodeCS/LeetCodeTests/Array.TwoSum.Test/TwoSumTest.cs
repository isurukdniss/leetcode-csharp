using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeCS.Array.TwoSum;

namespace LeetCodeTests.Array.TwoSum.Test
{
    [TestClass]
    public class TwoSumTest
    {
        [TestMethod]
        public void TestTwoSumBruteForceHappyPath()
        {
            // Arrange
            int[] a = { 2, 3, 7, 6, 4 };
            int target = 9;
            int[] expected = { 0, 2 };
            LeetCodeCS.Array.TwoSum.TwoSum ts = new LeetCodeCS.Array.TwoSum.TwoSum();

            // Act
            int[] result = ts.TwoSumBruteForce(a, target);


            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestTwoSumBruteForceEdgeCases1()
        {
            // Arrange
            int[] a = { };
            int target = 9;
            LeetCodeCS.Array.TwoSum.TwoSum ts = new LeetCodeCS.Array.TwoSum.TwoSum();

            // Act
            int[] result = ts.TwoSumBruteForce(a, target);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestTwoSumBruteForceEdgeCases2()
        {
            // Arrange
            int[] a = { 9 };
            int target = 9;
            LeetCodeCS.Array.TwoSum.TwoSum ts = new LeetCodeCS.Array.TwoSum.TwoSum();

            // Act
            int[] result = ts.TwoSumBruteForce(a, target);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestTwoSumBruteForceEdgeCases3()
        {
            // Arrange
            int[] a = { 9 , 1, 4, 3 };
            int target = 9;
            LeetCodeCS.Array.TwoSum.TwoSum ts = new LeetCodeCS.Array.TwoSum.TwoSum();

            // Act
            int[] result = ts.TwoSumBruteForce(a, target);

            // Assert
            Assert.IsNull(result);
        }
    }
}
