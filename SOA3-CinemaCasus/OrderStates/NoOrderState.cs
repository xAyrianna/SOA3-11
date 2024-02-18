using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA3_CinemaCasus
{
    public class NoOrderState : OrderState
    {
        private Order Order;

        public NoOrderState(Order Order)
        {
            this.Order = Order;
        }

        public void CreateOrder()
        {
            Order.State = new UnestablishedOrderState(Order);
            Console.WriteLine("Order created");
        }

        public void SubmitOrder()
        {
            Console.WriteLine("No order to submit...");
        }

        public void PayForOrder()
        {
            Console.WriteLine("No order to pay for...");
        }

        public void CancelOrder()
        {
            Console.WriteLine("No order to cancel...");
        }

        public void ChangeOrder()
        {
            Console.WriteLine("No order to change...");
        }

        public void SendNotice()
        {
            Console.WriteLine("What notice?..");
        }       
    }
}
