using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA3_CinemaCasus
{
    public class ProvisionalOrderState : IOrderState
    {
        private Order Order;

        public ProvisionalOrderState(Order Order)
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
            Console.WriteLine("Order cannot be changed.");
        }

        public void SendNotice()
        {
            Console.WriteLine("Notice has already been sent.");
        }
    }
}
