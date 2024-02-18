using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA3_CinemaCasus
{
    public class UnestablishedOrderState : OrderState
    {
        private Order Order;

        public UnestablishedOrderState(Order Order)
        {
            this.Order = Order;
        }

        public void CreateOrder()
        {
            Console.WriteLine("Order already exists.");
        }

        public void SubmitOrder()
        {
            Order.State = new ReservedOrderState(Order);
            Console.WriteLine("Order submitted");
        }

        public void PayForOrder()
        {
            Console.WriteLine("Tickets are not yet reserved.");
        }

        public void CancelOrder()
        {
            Order.State = new NoOrderState(Order);
            Console.WriteLine("Order cancelled");
        }

        public void ChangeOrder()
        {
            Console.WriteLine("Tickets are not yet reserved.");
        }

        public void SendNotice()
        {
            Console.WriteLine("Reserve the tickets first...");   
        }
    }
}
