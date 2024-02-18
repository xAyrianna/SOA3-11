using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA3_CinemaCasus
{
    public class ReservedOrderState : OrderState
    {
        private Order Order;

        public ReservedOrderState(Order Order)
        {
            this.Order = Order;
        }

        public void CreateOrder()
        {
            Console.WriteLine("Order already exists.");
        }

        public void SubmitOrder()
        {
            Console.WriteLine("Order has already been submitted.");
        }

        public void PayForOrder()
        {
            Order.State = new CompletedOrderState(Order);
            Console.WriteLine("Order paid");
        }

        public void CancelOrder()
        {
            Order.State = new NoOrderState(Order);
            Console.WriteLine("Order cancelled");
        }

        public void ChangeOrder()
        {
            Order.State = new UnestablishedOrderState(Order);
            Console.WriteLine("Order has been changed.");
        }

        public void SendNotice()
        {
            Order.State = new ProvisionalOrderState(Order);
            Console.WriteLine("24h notice sent");
        }
    }
}
