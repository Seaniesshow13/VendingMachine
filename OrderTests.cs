using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachineSYS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineSYS.Tests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void SetOrderTest()
        {
            Orders orders = new Orders();

            int result = Orders.getOrderId();

            Assert.IsTrue(result > 0, "Expect a positive value");
        }

        [TestMethod]
        public void GetOrderNum_Returns_Next_OrderNum()
        {
            // Arrange
            Orders orders = new Orders();

            // Act
            int result = orders.getOrderNum();

            // Assert
            Assert.IsTrue(result >= 1, "Expected OrderNum to be greater than or equal to 1.");
        }
    }
}
