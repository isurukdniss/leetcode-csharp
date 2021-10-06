using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Array.TwoSum.Test
{
    [TestClass]
    public class TwoSumOptimizedTest
    {
        [TestMethod]
        public void TestTwoSumOptimizedHappyPath()
        {
            // Arrange
            int[] a = { 2, 3, 7, 6, 4 };
            int target = 9;
            int[] expected = { 0, 2 };
            LeetCodeCS.Array.TwoSum.TwoSum ts = new LeetCodeCS.Array.TwoSum.TwoSum();

            // Act
            int[] result = ts.TwoSumOptimized(a, target);


            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestTwoSumOptimizedHappyPath2()
        {
            // Arrange
            int[] a = { 3, 2, 4 };
            int target = 6;
            int[] expected = { 1, 2 };
            LeetCodeCS.Array.TwoSum.TwoSum ts = new LeetCodeCS.Array.TwoSum.TwoSum();

            // Act
            int[] result = ts.TwoSumOptimized(a, target);


            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestTwoSumOptimizedEdgeCases1()
        {
            // Arrange
            int[] a = { };
            int target = 9;
            LeetCodeCS.Array.TwoSum.TwoSum ts = new LeetCodeCS.Array.TwoSum.TwoSum();

            // Act
            int[] result = ts.TwoSumOptimized(a, target);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestTwoSumOptimizedEdgeCases2()
        {
            // Arrange
            int[] a = { 9 };
            int target = 9;
            LeetCodeCS.Array.TwoSum.TwoSum ts = new LeetCodeCS.Array.TwoSum.TwoSum();

            // Act
            int[] result = ts.TwoSumOptimized(a, target);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestTwoSumOptimizedEdgeCases3()
        {
            // Arrange
            int[] a = { 9, 1, 4, 3 };
            int target = 9;
            LeetCodeCS.Array.TwoSum.TwoSum ts = new LeetCodeCS.Array.TwoSum.TwoSum();

            // Act
            int[] result = ts.TwoSumOptimized(a, target);

            // Assert
            Assert.IsNull(result);
        }
    }
}
