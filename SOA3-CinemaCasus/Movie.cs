using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOA3_CinemaCasus
{
    public class Movie
    {
        private string Title;
        private List<MovieScreening> MovieScreenings = new List<MovieScreening>();

        public Movie(string title)
        {
            this.Title = title;
        }

        public void AddScreening(MovieScreening screening)
        {
            MovieScreenings.Add(screening);
        }

        public override string ToString()
        {
            return Title;
        }
    }
}