using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ship;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private Ship.Shipping shipping;
        [TestMethod]
        public void TestMethod1()
        {
            shipping =  new Shipping();
            int expectedValue = 8;
            int returnValue = shipping.CalculatePackages(16, 2, 10);
            Assert.AreEqual(expectedValue, returnValue);
        }

        [TestMethod]
        public void TestMethod2()
        {
            shipping = new Shipping();
            int expectedValue = 4;
            int returnValue = shipping.CalculatePackages(16, 3, 10);
            Assert.AreEqual(expectedValue, returnValue);
        }

        [TestMethod]
        public void TestMethod3()
        {
            shipping = new Shipping();
            int expectedValue = -1;
            int returnValue = shipping.CalculatePackages(16, 0, 0);
            Assert.AreEqual(expectedValue, returnValue);
        }

        [TestMethod]
        public void TestMethod4()
        {
            shipping = new Shipping();
            int expectedValue = -1;
            int returnValue = shipping.CalculatePackages(16, 1, 0);
            Assert.AreEqual(expectedValue, returnValue);
        }
        [TestMethod]
        public void TestMethod5()
        {
            shipping = new Shipping();
            int expectedValue = -1;
            int returnValue = shipping.CalculatePackages(16, 0, 1);
            Assert.AreEqual(expectedValue, returnValue);
        }

    }
}
