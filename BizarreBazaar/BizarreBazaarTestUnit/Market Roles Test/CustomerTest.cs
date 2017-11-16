using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BizarreBazaar;

namespace BizarreBazaarTestUnit {
    [TestClass]
    public class CustomerTest {
        [TestMethod]
        public void TestCustomer()
        {
            Customer cust = new Customer("Per");

            Assert.AreEqual(cust.customerName, "Per");
        }

        [TestMethod]
        public void TestCustomerIsNull()
        {
            Customer cust = null;

            Assert.AreEqual(cust, null);
        }
    }
}
