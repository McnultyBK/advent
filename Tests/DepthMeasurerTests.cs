using Microsoft.VisualStudio.TestTools.UnitTesting;
using Depth;
using System;

namespace Tests
{
    [TestClass]
    public class DepthMeasurerTests
    {
        [TestMethod]
        [DataRow(0, new int[] { 200 })]
        [DataRow(0, new int[] { 200, 200 })]
        [DataRow(1, new int[] { 200, 201 })]
        [DataRow(2, new int[] { 200, 201, 202, 200 })]
        [DataRow(3, new int[] { 200, 201, 202, 200, 201 })]
        [DataRow(4, new int[] { 200, 201, 202, 200, 201, 202 })]
        [DataRow(5, new int[] { 200, 201, 202, 201, 200, 203, 205, 206 })]
        [DataRow(7, new int[] { 199, 200, 208, 210, 200, 207, 240, 269, 260, 263 })] // Example provided
        public void TestForDepthIncreases(int expected, int[] depths)
        {
            Assert.AreEqual(expected, DepthMeasurer.GetDepthIncreases(depths));
        }
    }
}
