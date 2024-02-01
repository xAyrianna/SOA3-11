using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOA3_CinemaCasus
{
    public class MovieTicket
    {
        private int RowNr;
        private int SeatNr;
        private Boolean IsPremium; 

        public MovieTicket(int RowNr, int SeatNr, Boolean IsPremium)
        {
            this.RowNr = RowNr;
            this.SeatNr = SeatNr;
            this.IsPremium = IsPremium;
        }

        public Boolean IsPremiumTicket(){
            return IsPremium;
        }

        public double GetPrice(){
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Ticket is at row: " + RowNr + " and seat: " + SeatNr;
        }
    }
}