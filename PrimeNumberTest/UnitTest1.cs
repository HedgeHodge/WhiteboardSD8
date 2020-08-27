using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeNumberTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(PrimeNumber.Prime.IsPrime(7));
            Assert.IsFalse(PrimeNumber.Prime.IsPrime(4));
        }
    }
}
