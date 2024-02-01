using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOA3_CinemaCasus
{
    public class Order
    {
        private int OrderNr;
        private Boolean IsStudentOrder;

        public Order(int orderNr, Boolean isStudentOrder)
        {
            OrderNr = orderNr;
            IsStudentOrder = isStudentOrder;
        }

        public int GetOrderNr()
        {
            return OrderNr;
        }

        public void AddSeatReservation(MovieTicket Ticket)
        {
            throw new NotImplementedException();
        }

        public double CalculatePrice()
        {
            throw new NotImplementedException();
        }

        public void Export(TicketExportFormat ExportFormat){
            throw new NotImplementedException();
        }
    }
}