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
        public Movie Movie { get; set; }

        public MovieScreening(DateTime DateAndTime, double PricePerSeat, Movie Movie)
        {
            this.DateAndTime = DateAndTime;
            this.PricePerSeat = PricePerSeat;
            this.Movie = Movie;
        }

        public double GetPricePerSeat()
        {
            return PricePerSeat;
        }

        public Boolean IsWeekend(){
            return DateAndTime.DayOfWeek == DayOfWeek.Friday || DateAndTime.DayOfWeek == DayOfWeek.Saturday || DateAndTime.DayOfWeek == DayOfWeek.Sunday;
        }
        
        public override string ToString()
        {
            return "Moviescreening is at: " + DateAndTime;
        }
    }
}