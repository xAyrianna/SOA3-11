using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA3_CinemaCasus.Tests.OrderStatesTests
{
    public class CompletedOrderStateTests
    {
        private Order Order;
        public CompletedOrderStateTests()
        {
            Order = new Order(1, false);
        }

        [Fact]
        public void CreateOrder_In_CompletedOrderState()
        {
            // Arrange
            Order.State = new CompletedOrderState(Order);

            // Act
            Order.State.CreateOrder();

            // Assert
            Assert.IsType<CompletedOrderState>(Order.State);
        }

        [Fact]
        public void SubmitOrder_In_CompletedOrderState()
        {
            // Arrange
            Order.State = new CompletedOrderState(Order);

            // Act
            Order.State.SubmitOrder();

            // Assert
            Assert.IsType<CompletedOrderState>(Order.State);
        }

        [Fact]
        public void PayForOrder_In_CompletedOrderState()
        {
            // Arrange
            Order.State = new CompletedOrderState(Order);

            // Act
            Order.State.PayForOrder();

            // Assert
            Assert.IsType<CompletedOrderState>(Order.State);
        }

        [Fact]
        public void CancelOrder_In_CompletedOrderState()
        {
            // Arrange
            Order.State = new CompletedOrderState(Order);

            // Act
            Order.State.CancelOrder();

            // Assert
            Assert.IsType<CompletedOrderState>(Order.State);
        }

        [Fact]
        public void ChangeOrder_In_CompletedOrderState()
        {
            // Arrange
            Order.State = new CompletedOrderState(Order);

            // Act
            Order.State.ChangeOrder();

            // Assert
            Assert.IsType<CompletedOrderState>(Order.State);
        }

        [Fact]
        public void SendNotice_In_CompletedOrderState()
        {
            // Arrange
            Order.State = new CompletedOrderState(Order);

            // Act
            Order.State.SendNotice();

            // Assert
            Assert.IsType<CompletedOrderState>(Order.State);
        }
    }
}
