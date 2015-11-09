using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayMinMaxSolution.Service;

namespace ArrayMinMaxSolution.Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void SampleArray1()
        {
            Solution Sol = new Solution(new int[] { 9, 4, 8, 5 });
            Assert.AreEqual(6, Sol.MinElementNonInArray);
        }

        [TestMethod]
        public void SampleArray2()
        {
            Solution Sol = new Solution(new int[] { 9, 11, 8, 15 });
            Assert.AreEqual(10, Sol.MinElementNonInArray);
        }

        [TestMethod]
        public void ElementDoesNotExists()
        {
            Solution Sol = new Solution(new int[] { 1, 2, 3, 4 });
            Assert.AreEqual(-1, Sol.MinElementNonInArray);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyArray()
        {
            Solution Sol = new Solution(new int[] {});
        }
    }
}
