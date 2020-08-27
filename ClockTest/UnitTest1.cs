using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Clock;

namespace ClockTest
{
    [TestClass]
    public class UnitTest1
    {
        DateTime elevenThirty = new DateTime(2020, 08, 13, 12, 30, 00);
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, ClockAngles.GetAngle(elevenThirty));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(30, ClockAngles.GetAngle(elevenThirty));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(60, ClockAngles.GetAngle(elevenThirty));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(90, ClockAngles.GetAngle(elevenThirty));
        }
        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(120, ClockAngles.GetAngle(elevenThirty));
        }
        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(150, ClockAngles.GetAngle(elevenThirty));
        }
        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual(180, ClockAngles.GetAngle(elevenThirty));
        }
        [TestMethod]
        public void TestMethod8()
        {
            Assert.AreEqual(210, ClockAngles.GetAngle(elevenThirty));
        }
        [TestMethod]
        public void TestMethod9()
        {
            Assert.AreEqual(240, ClockAngles.GetAngle(elevenThirty));
        }
        [TestMethod]
        public void TestMethod10()
        {
            Assert.AreEqual(270, ClockAngles.GetAngle(elevenThirty));
        }
    }
}
