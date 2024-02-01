using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOA3_CinemaCasus
{
    public class MovieScreening
    {
        private DateTime DateAndTime;
        private double PricePerSeat;

        public MovieScreening(DateTime DateAndTime, double PricePerSeat)
        {
            this.DateAndTime = DateAndTime;
            this.PricePerSeat = PricePerSeat;
        }

        public double GetPricePerSeat()
        {
            return PricePerSeat;
        }

        public override string ToString()
        {
            return "Moviescreening is at: " + DateAndTime;
        }
    }
}