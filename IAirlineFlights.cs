using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject
{
    interface IAirlineFlights
    {
        void ShowScreen();

        void ShowFlights(List<Flights> arrivalsFlights);

        void AddFlight(ref List<Flights> departuresFlights);

        void EditFlight(ref List<Flights> departuresFlights, int index);

        void EraseFlight(ref List<Flights> arrivalsFlights, int index);

        void SearchFlight(List<Flights> arrivalsFlights, string flight);

        void SearchCheapest(List<Flights> arrivalsFlights);
    }
}
