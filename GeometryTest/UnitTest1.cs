using Microsoft.VisualStudio.TestTools.UnitTesting;
using Geometry;

namespace GeometryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(5.0, Triangle.AreaOfTriangle(5.0, 2.0));
            Assert.AreEqual(5.0, Triangle.AreaOfTriangle(2.0, 5.0));
        }
    }
}
