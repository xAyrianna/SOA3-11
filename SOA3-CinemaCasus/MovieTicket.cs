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
        public MovieScreening Screening {get ; set;}

        public MovieTicket(int RowNr, int SeatNr, Boolean IsPremium, MovieScreening Screening)
        {
            this.RowNr = RowNr;
            this.SeatNr = SeatNr;
            this.IsPremium = IsPremium;
            this.Screening = Screening;
        }

        public Boolean IsPremiumTicket(){
            return IsPremium;
        }

        public double GetPrice(){
            return Screening.GetPricePerSeat();
        }

        public override string ToString()
        {
            return $"Row: {RowNr}, Seat: {SeatNr}, Premium: {IsPremium}";
        }
    }
}