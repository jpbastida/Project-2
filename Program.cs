using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject
{
    class Program : DataBase
    {
        static Arrivals arrivals = new Arrivals();
        static Departures departures = new Departures();
        static ArrivalsPassengers passengersListArrivals = new ArrivalsPassengers();
        static DeparturesPassengers passengersListDepartures = new DeparturesPassengers();
        static bool _InArrivals = true;
        public static bool InArrivals
        {
            get { return _InArrivals; }
            set { _InArrivals = value; }
        }

        static void Main(string[] args)
        {
            Console.WindowHeight = 30;
            Console.WindowWidth = 170;
            Console.CursorVisible = false;
            Console.CursorVisible = true;
            string optionMenu;
            arrivals.ShowScreen();
            arrivals.ShowFlights(arrivalsInfo);
            Console.WriteLine();

            while (true)
            {
                Console.SetCursorPosition(0, 20);
                Console.Write("CHOOSE AN OPTION: ");
                optionMenu = Console.ReadLine();
                if (optionMenu != String.Empty)
                {
                    if (InArrivals)
                    {
                        MainMenu (int.Parse(optionMenu), arrivalsInfo, passengersArrivals);
                    }
                    else
                    {
                        MainMenu (int.Parse(optionMenu), departuresInfo, passengersDepartures);
                    }
                }
            }
        }

        static void MainMenu(int option, List<Flights> listFlights, List<Passengers> listPassengers)
        {
            switch (option)
            {
                case 1:
                    SelectScreenInfo();
                    break;

                case 2:
                    ShowFlightsList(listFlights);
                    break;

                case 3:
                    ShowPassengersList(listPassengers);
                    break;

                case 4:
                    OptionForFlight(listFlights);
                    break;

                case 5:
                    OptionsForPassengers(listPassengers);
                    break;

                case 6:
                    SearchPassenger(listPassengers);
                    break;

                case 7:
                    SearchByPassport(listPassengers);
                    break;

                case 8:
                    SearchByFlight(listFlights);
                    break;

                case 9:
                    arrivals.SearchCheapest(listFlights);
                    break;

                default:
                    Console.WriteLine("WRONG OPTION! Press any key to continue...");
                    Console.ReadLine();
                    arrivals.ShowScreen();
                    arrivals.ShowFlights(arrivalsInfo);
                    InArrivals = true;
                    break;
            }
        }

        private static void SearchByFlight(List<Flights> listFlights)
        {
            ShowFlightList();
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("                               ");
            Console.SetCursorPosition(0, 20);
            Console.Write("WRITE FLIGHT: ");
            arrivals.SearchFlight(listFlights, Console.ReadLine());
        }

        private static void SearchByPassport(List<Passengers> listPassengers)
        {
            ShowListPassengers(listPassengers);
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("                                 ");
            Console.SetCursorPosition(0, 20);
            Console.Write("WRITE PASSPORT No.: ");
            if (InArrivals)
            {
                passengersListArrivals.SearchPassport(listPassengers, Console.ReadLine());
            }
            else
            {
                passengersListDepartures.SearchPassport(listPassengers, Console.ReadLine());
            }
        }

        private static void SearchPassenger(List<Passengers> listPassengers)
        {
            ShowListPassengers(listPassengers);
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("                               ");
            Console.SetCursorPosition(0, 20);
            Console.Write("WRITE NAME/SURNAME: ");
            if (InArrivals)
            {
                passengersListArrivals.SearchPassenger(listPassengers, Console.ReadLine());
            }
            else
            {
                passengersListDepartures.SearchPassenger(listPassengers, Console.ReadLine());
            }
        }

        private static void OptionsForPassengers(List<Passengers> listPassengers)
        {
            ShowListPassengers(listPassengers);
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("                             ");
            Console.SetCursorPosition(0, 20);
            Console.Write("1: ADD, 2: EDIT, 3:ERASE : ");
            int passengersOpMenu = int.Parse(Console.ReadLine());
            PassengersOptionMenu(passengersOpMenu, ref listPassengers);
        }

        private static void OptionForFlight(List<Flights> listFlights)
        {
            ShowFlightList();
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("                         ");
            Console.SetCursorPosition(0, 20);
            Console.Write("1: ADD, 2: EDIT, 3:ERASE : ");
            int flightOpMenu = int.Parse(Console.ReadLine());
            FlightOptionMenu(flightOpMenu, ref listFlights);
        }

        private static void ShowPassengersList(List<Passengers> listPassengers)
        {
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("                         ");
            Console.SetCursorPosition(0, 20);
            Console.Write("CHOOSE A FLIGHT: ");
            string flightChosen = Console.ReadLine();
            if (InArrivals)
            {
                passengersListArrivals.ShowPassengersHeaders();
                passengersListArrivals.ShowPassengers(listPassengers, flightChosen);
            }
            else
            {
                passengersListDepartures.ShowPassengersHeaders();
                passengersListDepartures.ShowPassengers(listPassengers, flightChosen);
            }
        }

        private static void ShowFlightsList(List<Flights> listFlights)
        {
            if (InArrivals)
            {
                arrivals.ShowScreen();
                arrivals.ShowFlights(listFlights);
            }
            else
            {
                departures.ShowScreen();
                departures.ShowFlights(listFlights);
            }
        }

        private static void SelectScreenInfo()
        {
            if (InArrivals)
            {
                departures.ShowScreen();
                departures.ShowFlights(departuresInfo);
                InArrivals = false;
            }
            else
            {
                arrivals.ShowScreen();
                arrivals.ShowFlights(arrivalsInfo);
                InArrivals = true;
            }
        }

        private static void ShowListPassengers(List<Passengers> listPassengers)
        {
            if (InArrivals)
            {
                passengersListArrivals.ShowPassengersHeaders();
                passengersListArrivals.ShowPassengers(listPassengers);
            }
            else
            {
                passengersListDepartures.ShowPassengersHeaders();
                passengersListDepartures.ShowPassengers(listPassengers);
            }
        }

        private static void ShowFlightList()
        {
            if (InArrivals)
            {
                arrivals.ShowScreen();
                arrivals.ShowFlights(arrivalsInfo);
            }
            else
            {
                departures.ShowScreen();
                departures.ShowFlights(departuresInfo);
            }
        }

        private static void PassengersOptionMenu(int option, ref List<Passengers> passengers)
        {
            DataStrings dataStr = new DataStrings();

            switch (option)
            {
                case 1:
                    AddPassenger(ref passengers);
                    break;

                case 2:
                    EditPassenger(ref passengers);
                    break;

                case 3:
                    ErasePassenger(ref passengers);
                    break;

                default:
                    Console.WriteLine("WRONG OPTION! Press any key to continue...");
                    Console.ReadLine();
                    arrivals.ShowScreen();
                    arrivals.ShowFlights(arrivalsInfo);
                    break;
            }
        }

        private static void ErasePassenger(ref List<Passengers> passengers)
        {
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("                                 ");
            Console.SetCursorPosition(0, 20);
            Console.Write("CHOOSE INDEX: ");
            int ind = int.Parse(Console.ReadLine());
            if (InArrivals)
            {
                passengersListArrivals.ErasePassenger(ref passengers, ind);
                passengersListArrivals.ShowPassengersHeaders();
                passengersListArrivals.ShowPassengers(passengers);
            }
            else
            {
                passengersListDepartures.ErasePassenger(ref passengers, ind);
                passengersListDepartures.ShowPassengersHeaders();
                passengersListDepartures.ShowPassengers(passengers);
            }
        }

        private static void EditPassenger(ref List<Passengers> passengers)
        {
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("                                 ");
            Console.SetCursorPosition(0, 20);
            Console.Write("CHOOSE INDEX: ");
            int n = int.Parse(Console.ReadLine());
            if (InArrivals)
            {
                passengersListArrivals.EditPassenger(ref passengers, n);
                passengersListArrivals.ShowPassengersHeaders();
                passengersListArrivals.ShowPassengers(passengers);
            }
            else
            {
                passengersListDepartures.EditPassenger(ref passengers, n);
                passengersListDepartures.ShowPassengersHeaders();
                passengersListDepartures.ShowPassengers(passengers);
            }                 
        }

        private static void AddPassenger(ref List<Passengers> passengers)
        {
            if (InArrivals)
            {
                passengersListArrivals.AddPassenger(ref passengers);
                passengersListArrivals.ShowPassengersHeaders();
                passengersListArrivals.ShowPassengers(passengers);
            }
            else
            {
                passengersListDepartures.AddPassenger(ref passengers);
                passengersListDepartures.ShowPassengersHeaders();
                passengersListDepartures.ShowPassengers(passengers);
            }
        }

        private static void FlightOptionMenu(int flightOpMenu, ref List<Flights> flights)
        {
            DataStrings dataStr = new DataStrings();

            switch (flightOpMenu)
            {
                case 1:
                    AddFlight(ref flights);
                    break;

                case 2:
                    EditFlight(ref flights);
                    break;

                case 3:
                    EraseFlight(ref flights);
                    break;

                default:
                    Console.WriteLine("WRONG OPTION! Press any key to continue...");
                    Console.ReadLine();
                    arrivals.ShowScreen();
                    arrivals.ShowFlights(arrivalsInfo);
                    break;
            }
        }

        private static void EraseFlight(ref List<Flights> flights)
        {
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("                                 ");
            Console.SetCursorPosition(0, 20);
            Console.Write("CHOOSE INDEX: ");
            int ind = int.Parse(Console.ReadLine());
            if (InArrivals)
            {
                arrivals.EraseFlight(ref flights, ind);
                arrivals.ShowScreen();
                arrivals.ShowFlights(flights);
            }
            else
            {
                departures.EraseFlight(ref flights, ind);
                departures.ShowScreen();
                departures.ShowFlights(flights);
            }
        }

        private static void EditFlight(ref List<Flights> flights)
        {
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("                                  ");
            Console.SetCursorPosition(0, 20);
            Console.Write("CHOOSE INDEX: ");
            int n = int.Parse(Console.ReadLine());
            if (InArrivals)
            {
                arrivals.EditFlight(ref flights, n);
                arrivals.ShowScreen();
                arrivals.ShowFlights(flights);
            }
            else
            {
                departures.EditFlight(ref flights, n);
                departures.ShowScreen();
                departures.ShowFlights(flights);
            }
        }

        private static void AddFlight(ref List<Flights> flights)
        {
            if (InArrivals)
            {
                arrivals.AddFlight(ref flights);
                arrivals.ShowScreen();
                arrivals.ShowFlights(arrivalsInfo);
            }
            else
            {
                departures.AddFlight(ref flights);
                departures.ShowScreen();
                departures.ShowFlights(departuresInfo);
            }
        }
    }
}
