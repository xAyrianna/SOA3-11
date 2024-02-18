using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA3_CinemaCasus.Tests.OrderStatesTests
{
    public class ProvisionalOrderStateTests
    {
        private Order Order;
        public ProvisionalOrderStateTests()
        {
            Order = new Order(1, false);
        }

        [Fact]
        public void CreateOrder_In_ProvisionalOrderState()
        {
            // Arrange
            Order.State = new ProvisionalOrderState(Order);

            // Act
            Order.State.CreateOrder();

            // Assert
            Assert.IsType<ProvisionalOrderState>(Order.State);
        }

        [Fact]
        public void SubmitOrder_In_ProvisionalOrderState()
        {
            // Arrange
            Order.State = new ProvisionalOrderState(Order);

            // Act
            Order.State.SubmitOrder();

            // Assert
            Assert.IsType<ProvisionalOrderState>(Order.State);
        }

        [Fact]
        public void PayForOrder_In_ProvisionalOrderState()
        {
            // Arrange
            Order.State = new ProvisionalOrderState(Order);

            // Act
            Order.State.PayForOrder();

            // Assert
            Assert.IsType<CompletedOrderState>(Order.State);
        }

        [Fact]
        public void CancelOrder_In_ProvisionalOrderState()
        {
            // Arrange
            Order.State = new ProvisionalOrderState(Order);

            // Act
            Order.State.CancelOrder();

            // Assert
            Assert.IsType<NoOrderState>(Order.State);
        }

        [Fact]
        public void ChangeOrder_In_ProvisionalOrderState()
        {
            // Arrange
            Order.State = new ProvisionalOrderState(Order);

            // Act
            Order.State.ChangeOrder();

            // Assert
            Assert.IsType<ProvisionalOrderState>(Order.State);
        }

        [Fact]
        public void SendNotice_In_ProvisionalOrderState()
        {
            // Arrange
            Order.State = new ProvisionalOrderState(Order);

            // Act
            Order.State.SendNotice();

            // Assert
            Assert.IsType<ProvisionalOrderState>(Order.State);
        }
    }
}
