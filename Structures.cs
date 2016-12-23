using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject
{
    struct Titles
    {
        public string Title;
        public string TitleDepartures;
        public string TitleArrivals;

        public Titles(string title, string departure, string arrive)
        {
            Title = title;
            TitleDepartures = departure;
            TitleArrivals = arrive;
        }
    }
}
