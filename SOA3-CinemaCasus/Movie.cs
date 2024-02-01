using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOA3_CinemaCasus
{
    public class Movie
    {
        private string Title;

        public Movie(string title)
        {
            this.Title = title;
        }

        public void AddScreening(MovieScreening screening)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Title;
        }
    }
}