using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject
{
    interface IAirlinePassengers
    {
        void ShowPassengersHeaders();

        void ShowPassengers(List<Passengers> departuresPassengers, string FlightNumber);

        void ShowPassengers(List<Passengers> departuresPassengers);

        void AddPassenger(ref List<Passengers> departuresPassengers);

        void EditPassenger(ref List<Passengers> departuresPassengers, int index);

        void ErasePassenger(ref List<Passengers> departuresPassengers, int index);

        void SearchPassenger(List<Passengers> departuresPassengers, string passenger);

        void SearchPassport(List<Passengers> departuresPassengers, string passport);
    }
}
