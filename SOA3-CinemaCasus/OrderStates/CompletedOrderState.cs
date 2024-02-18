namespace SOA3_CinemaCasus
{
    public class CompletedOrderState : IOrderState
    {
        private Order Order;

        public CompletedOrderState(Order Order)
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
            Console.WriteLine("Order has already been paid for.");
        }

        public void CancelOrder()
        {
            Console.WriteLine("Order can no longer be cancelled.");
        }

        public void ChangeOrder()
        {
            Console.WriteLine("Order can no longer be changed.");
        }

        public void SendNotice()
        {
            Console.WriteLine("Order has already been paid, notice not necessary.");
        }
    }
}
