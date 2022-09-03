using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        [TestMethod]
        public void testEndArray() {
            CircularArray CArr = new CircularArray(5);
            double[] Arr = {0.5, 0.2, 0.05};
            CArr.Fill(Arr);
            double firstNum = CArr.Shift(0.2);
            Assert.AreEqual(CArr[CArr.Length-1], 0.2);
        }
    }
}
