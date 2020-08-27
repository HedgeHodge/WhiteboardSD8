using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumOfDistinct;

namespace NumOfDistinctTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] testNums1 = { 8, 6, 7, 5, 3, 0, 9 };
            Assert.AreEqual(7, DistinctNumbers.CountDistinct(testNums1));

            int[] testNums2 = { 9, 2, 1, 0, 1 };
            Assert.AreEqual(4, DistinctNumbers.CountDistinct(testNums2));
        }
    }
}
