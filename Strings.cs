using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject
{
    public class DataStrings
    {
        public string[] HeadTags = { "TIME", "FLIGHT", "CITY", "TERMINAL", "GATE", "STATUS", "PRICE" };
        public string[] HeadPassengers = { "NAME", "SURNAME", "NATIONALITY", "PASSPORT", "BIRTHDAY", "SEX", "TICKET", "CLASS", "PRICE" };
        public string[] PassengersToAdd = { "FLIGHT", "NAME", "SURNAME", "NATIONALITY", "PASSPORT", "BIRTHDAY", "SEX", "TICKET", "CLASS", "PRICE" };

        public string MenuArrivals = (@"
MENU:                       |
                            |
                            |
1 - GO TO DEPARTURES        |
2 - FLIGHTS                 |
3 - PASSENGER LIST          |    
4 - MENU FLIGHTS            |
5 - MENU PASSENGERS         |
6 - SEARCH PASSENGER        |
7 - SEARCH BY PASSPORT      |
8 - SEARCH FLIGHT           |
9 - SEARCH CHEAPEST FLIGHT  |
                            |
____________________________|");

        public string MenuDepartures = (@"
MENU:                       |
                            |
                            |
1 - GO TO ARRIVALS          |
2 - FLIGHTS                 |
3 - PASSENGER LIST          |    
4 - MENU FLIGHTS            |
5 - MENU PASSENGERS         |
6 - SEARCH PASSENGER        |
7 - SEARCH BY PASSPORT      |
8 - SEARCH FLIGHT           |
9 - SEARCH CHEAPEST FLIGHT  |
                            |
____________________________|");
    }
}
