using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace SOA3_CinemaCasus
{
    public class Order
    {
        private int OrderNr;
        private Boolean IsStudentOrder;
        private List<MovieTicket> SeatReservations = new List<MovieTicket>();

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
            SeatReservations.Add(Ticket);
        }

        public double CalculatePrice()
        {
            int NumberOfTickets = SeatReservations.Count();
            if (NumberOfTickets == 0)
            {
                return 0;
            }
            Boolean IsWeekend = SeatReservations[0].Screening.IsWeekend();
            Boolean IsSecondTicketfree = IsStudentOrder || !IsWeekend;
            double PremiumExtra = IsStudentOrder ? 2 : 3;
            double Price = 0;

            for (int i = 1; i <= NumberOfTickets; i++)
            {
                if (i % 2 == 0 && IsSecondTicketfree)
                {
                    continue;
                }
                MovieTicket Ticket = SeatReservations[i - 1];
                Price += Ticket.GetPrice();

                if (Ticket.IsPremiumTicket())
                {
                    Price += PremiumExtra;
                }

            }
            if (!IsStudentOrder && NumberOfTickets >= 6)
            {
                Price = Price * 0.9;
            }
            return Price;
        }

        public void Export(TicketExportFormat ExportFormat)
        {
            if (ExportFormat == TicketExportFormat.JSON)
            {
                using (StreamWriter sw = new StreamWriter("Orders/Order" + OrderNr + ".json"))
                {
                    sw.WriteLine("{");
                    sw.WriteLine("\t\"OrderNr\": " + OrderNr + ",");
                    sw.WriteLine("\t\"Tickets\": [");
                    for (int i = 0; i < SeatReservations.Count(); i++)
                    {
                        MovieTicket Ticket = SeatReservations[i];
                        if (i == SeatReservations.Count() - 1)
                        {
                            sw.WriteLine("\t\t\"" + Ticket + "\"");
                            continue;
                        }
                        sw.WriteLine("\t\t\"" + Ticket + "\",");
                    }
                    sw.WriteLine("\t],");
                    sw.WriteLine("\t\"TotalPrice\": " + CalculatePrice());
                    sw.WriteLine("}");
                }
            }
            else if (ExportFormat == TicketExportFormat.PLAINTEXT)
            {
                using (StreamWriter sw = new StreamWriter("Orders/Order" + OrderNr + ".txt"))
                {
                    sw.WriteLine("OrderNr: " + OrderNr);
                    foreach (MovieTicket Ticket in SeatReservations)
                    {
                        sw.WriteLine(Ticket);
                    }
                    sw.WriteLine("Total Price: " + CalculatePrice());
                }
            }
            else
            {
                throw new Exception("Unsupported ExportFormat");
            }
        }
    }
}