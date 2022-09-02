using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PianoSimulation;

namespace PianoSimulationTests
{
    [TestClass]
    public class CircularArrayTest
    {
        [TestMethod]
        public void TestLength()
        {
            CircularArray CArr = new CircularArray(2);
            Assert.AreEqual(CArr.Length,2);
        }
        [TestMethod]
        public void testShift() {
            CircularArray CArr = new CircularArray(5);
            double[] Arr = {0.5, 0.2, 0.05};
            CArr.Fill(Arr);
            Assert.AreEqual(CArr.Shift(0.2), 0.5);
        }
    }
}
