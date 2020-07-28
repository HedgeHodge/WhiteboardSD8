using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimeDiffFunction;


namespace TimeDiffFunction
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(15, TimeFunction.TimeBetween(10, 55, 11, 10));
        }
    }
}
