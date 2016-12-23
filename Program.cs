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
        static bool inArrivals = true;

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
                    if (inArrivals)
                    {
                        MainMenuArrivals (int.Parse(optionMenu), arrivalsInfo, passengersArrivals);
                    }
                    else
                    {
                        MainMenuDepartures (int.Parse(optionMenu), departuresInfo, passengersDepartures);
                    }
                }
            }
        }

        static void MainMenuArrivals(int option, List<Flights> listFlights, List<Passengers> listPassengers)
        {
            switch (option)
            {
                case 1:
                    departures.ShowScreen();
                    departures.ShowFlights(departuresInfo);
                    inArrivals = false;
                    break;

                case 2:
                    arrivals.ShowScreen();
                    arrivals.ShowFlights(listFlights);
                    break;

                case 3:
                    Console.SetCursorPosition(0, 20);
                    Console.WriteLine("                         ");
                    Console.SetCursorPosition(0, 20);
                    Console.Write("CHOOSE A FLIGHT: ");
                    string flightChosen = Console.ReadLine();
                    passengersListArrivals.ShowPassengersHeaders();
                    passengersListArrivals.ShowPassengers(listPassengers, flightChosen);
                    break;

                case 4:
                    arrivals.ShowScreen();
                    arrivals.ShowFlights(arrivalsInfo);
                    Console.SetCursorPosition(0, 20);
                    Console.WriteLine("                         ");
                    Console.SetCursorPosition(0, 20);
                    Console.Write("1: ADD, 2: EDIT, 3:ERASE : ");
                    int flightOpMenu = int.Parse(Console.ReadLine());
                    ArrivalsFlightOptionMenu(flightOpMenu,ref listFlights);
                    break;

                case 5:
                    passengersListArrivals.ShowPassengersHeaders();
                    passengersListArrivals.ShowPassengers(listPassengers);
                    Console.SetCursorPosition(0, 20);
                    Console.WriteLine("                             ");
                    Console.SetCursorPosition(0, 20);
                    Console.Write("1: ADD, 2: EDIT, 3:ERASE : ");
                    int passengersOpMenu = int.Parse(Console.ReadLine());
                    ArrivalsPassengersOptionMenu(passengersOpMenu, listPassengers);
                    break;

                case 6:
                    passengersListArrivals.ShowPassengersHeaders();
                    passengersListArrivals.ShowPassengers(listPassengers);
                    Console.SetCursorPosition(0, 20);
                    Console.WriteLine("                               ");
                    Console.SetCursorPosition(0, 20);
                    Console.Write("WRITE NAME/SURNAME: ");
                    passengersListArrivals.SearchPassenger(listPassengers, Console.ReadLine());
                    break;

                case 7:
                    passengersListArrivals.ShowPassengersHeaders();
                    passengersListArrivals.ShowPassengers(listPassengers);
                    Console.SetCursorPosition(0, 20);
                    Console.WriteLine("                                 ");
                    Console.SetCursorPosition(0, 20);
                    Console.Write("WRITE PASSPORT No.: ");
                    passengersListArrivals.SearchPassport(listPassengers, Console.ReadLine());
                    break;

                case 8:
                    arrivals.ShowScreen();
                    arrivals.ShowFlights(arrivalsInfo);
                    Console.SetCursorPosition(0, 20);
                    Console.WriteLine("                               ");
                    Console.SetCursorPosition(0, 20);
                    Console.Write("WRITE FLIGHT: ");
                    arrivals.SearchFlight(listFlights, Console.ReadLine());
                    break;

                case 9:
                    arrivals.SearchCheapest(listFlights);
                    break;

                default:
                    Console.WriteLine("WRONG OPTION! Press any key to continue...");
                    Console.ReadLine();
                    arrivals.ShowScreen();
                    arrivals.ShowFlights(arrivalsInfo);
                    break;
            }
        }

        static void MainMenuDepartures(int option, List<Flights> listFlights, List<Passengers> listPassengers)
        {
            switch (option)
            {
                case 1:
                    arrivals.ShowScreen();
                    arrivals.ShowFlights(arrivalsInfo);
                    inArrivals = true;
                    break;

                case 2:
                    departures.ShowScreen();
                    departures.ShowFlights(listFlights);
                    break;

                case 3:
                    Console.SetCursorPosition(0, 20);
                    Console.WriteLine("                         ");
                    Console.SetCursorPosition(0, 20);
                    Console.Write("CHOOSE A FLIGHT: ");
                    string flightChosen = Console.ReadLine();
                    passengersListDepartures.ShowPassengersHeaders();
                    passengersListDepartures.ShowPassengers(listPassengers, flightChosen);
                    break;

                case 4:
                    departures.ShowScreen();
                    departures.ShowFlights(arrivalsInfo);
                    Console.SetCursorPosition(0, 20);
                    Console.WriteLine("                         ");
                    Console.SetCursorPosition(0, 20);
                    Console.Write("1: ADD, 2: EDIT, 3:ERASE : ");
                    int flightOpMenu = int.Parse(Console.ReadLine());
                    DeparturesFlightOptionMenu(flightOpMenu, ref listFlights);
                    break;

                case 5:
                    passengersListDepartures.ShowPassengersHeaders();
                    passengersListDepartures.ShowPassengers(listPassengers);
                    Console.SetCursorPosition(0, 20);
                    Console.WriteLine("                             ");
                    Console.SetCursorPosition(0, 20);
                    Console.Write("1: ADD, 2: EDIT, 3:ERASE : ");
                    int passengersOpMenu = int.Parse(Console.ReadLine());
                    DeparturesPassengersOptionMenu(passengersOpMenu, listPassengers);
                    break;

                case 6:
                    passengersListDepartures.ShowPassengersHeaders();
                    passengersListDepartures.ShowPassengers(listPassengers);
                    Console.SetCursorPosition(0, 20);
                    Console.WriteLine("                               ");
                    Console.SetCursorPosition(0, 20);
                    Console.Write("WRITE NAME/SURNAME: ");
                    passengersListDepartures.SearchPassenger(listPassengers, Console.ReadLine());
                    break;

                case 7:
                    passengersListDepartures.ShowPassengersHeaders();
                    passengersListDepartures.ShowPassengers(listPassengers);
                    Console.SetCursorPosition(0, 20);
                    Console.WriteLine("                                 ");
                    Console.SetCursorPosition(0, 20);
                    Console.Write("WRITE PASSPORT No.: ");
                    passengersListDepartures.SearchPassport(listPassengers, Console.ReadLine());
                    break;

                case 8:
                    departures.ShowScreen();
                    departures.ShowFlights(arrivalsInfo);
                    Console.SetCursorPosition(0, 20);
                    Console.WriteLine("                               ");
                    Console.SetCursorPosition(0, 20);
                    Console.Write("WRITE FLIGHT: ");
                    departures.SearchFlight(listFlights, Console.ReadLine());
                    break;

                case 9:
                    departures.SearchCheapest(listFlights);
                    break;

                default:
                    Console.WriteLine("WRONG OPTION! Press any key to continue...");
                    Console.ReadLine();
                    departures.ShowScreen();
                    departures.ShowFlights(arrivalsInfo);
                    break;
            }
        }

        private static void ArrivalsPassengersOptionMenu
            (int option, List<Passengers> passengers)
        {
            DataStrings dataStr = new DataStrings();

            switch (option)
            {
                case 1:
                    passengersListArrivals.AddPassenger(ref passengers);
                    passengersListArrivals.ShowPassengersHeaders();
                    passengersListArrivals.ShowPassengers(passengers);
                    break;

                case 2:
                    Console.SetCursorPosition(0, 20);
                    Console.WriteLine("                                 ");
                    Console.SetCursorPosition(0, 20);
                    Console.Write("CHOOSE INDEX: ");
                    int n = int.Parse(Console.ReadLine());
                    passengersListArrivals.EditPassenger(ref passengers, n);
                    passengersListArrivals.ShowPassengersHeaders();
                    passengersListArrivals.ShowPassengers(passengers);
                    break;

                case 3:
                    Console.SetCursorPosition(0, 20);
                    Console.WriteLine("                                 ");
                    Console.SetCursorPosition(0, 20);
                    Console.Write("CHOOSE INDEX: ");
                    int ind = int.Parse(Console.ReadLine());
                    passengersListArrivals.ErasePassenger(ref passengers, ind);
                    passengersListArrivals.ShowPassengersHeaders();
                    passengersListArrivals.ShowPassengers(passengers);
                    break;

                default:
                    Console.WriteLine("WRONG OPTION! Press any key to continue...");
                    Console.ReadLine();
                    arrivals.ShowScreen();
                    arrivals.ShowFlights(arrivalsInfo);
                    break;
            }
        }

        private static void DeparturesPassengersOptionMenu(int option, List<Passengers> passengers )
        {
            DataStrings dataStr = new DataStrings();

            switch (option)
            {
                case 1:
                    passengersListDepartures.AddPassenger(ref passengers);
                    passengersListDepartures.ShowPassengersHeaders();
                    passengersListDepartures.ShowPassengers(passengers);
                    break;

                case 2:
                    Console.SetCursorPosition(0, 20);
                    Console.WriteLine("                                 ");
                    Console.SetCursorPosition(0, 20);
                    Console.Write("CHOOSE INDEX: ");
                    int n = int.Parse(Console.ReadLine());
                    passengersListDepartures.EditPassenger(ref passengers, n);
                    passengersListDepartures.ShowPassengersHeaders();
                    passengersListDepartures.ShowPassengers(passengers);
                    break;

                case 3:
                    Console.SetCursorPosition(0, 20);
                    Console.WriteLine("                                 ");
                    Console.SetCursorPosition(0, 20);
                    Console.Write("CHOOSE INDEX: ");
                    int ind = int.Parse(Console.ReadLine());
                    passengersListDepartures.ErasePassenger(ref passengers, ind);
                    passengersListDepartures.ShowPassengersHeaders();
                    passengersListDepartures.ShowPassengers(passengers);
                    break;

                default:
                    Console.WriteLine("WRONG OPTION! Press any key to continue...");
                    Console.ReadLine();
                    departures.ShowScreen();
                    departures.ShowFlights(arrivalsInfo);
                    break;
            }
        }

        private static void ArrivalsFlightOptionMenu(int flightOpMenu, ref List<Flights> flights)
        {
            DataStrings dataStr = new DataStrings();

            switch (flightOpMenu)
            {
                case 1:
                    arrivals.AddFlight(ref flights);
                    arrivals.ShowScreen();
                    arrivals.ShowFlights(arrivalsInfo);
                    break;

                case 2:
                    Console.SetCursorPosition(0, 20);
                    Console.WriteLine("                                 ");
                    Console.SetCursorPosition(0, 20);
                    Console.Write("CHOOSE INDEX: ");
                    int n = int.Parse(Console.ReadLine());
                    arrivals.EditFlight(ref flights, n);
                    arrivals.ShowScreen();
                    arrivals.ShowFlights(flights);
                    break;

                case 3:
                    Console.SetCursorPosition(0, 20);
                    Console.WriteLine("                                 ");
                    Console.SetCursorPosition(0, 20);
                    Console.Write("CHOOSE INDEX: ");
                    int ind = int.Parse(Console.ReadLine());
                    arrivals.EraseFlight(ref flights, ind);
                    arrivals.ShowScreen();
                    arrivals.ShowFlights(flights);
                    break;

                default:
                    Console.WriteLine("WRONG OPTION! Press any key to continue...");
                    Console.ReadLine();
                    arrivals.ShowScreen();
                    arrivals.ShowFlights(arrivalsInfo);
                    break;
            }
        }

        private static void DeparturesFlightOptionMenu(int flightOpMenu, ref List<Flights> flights)
        {
            DataStrings dataStr = new DataStrings();

            switch (flightOpMenu)
            {
                case 1:
                    departures.AddFlight(ref flights);
                    departures.ShowScreen();
                    departures.ShowFlights(arrivalsInfo);
                    break;

                case 2:
                    Console.SetCursorPosition(0, 20);
                    Console.WriteLine("                                 ");
                    Console.SetCursorPosition(0, 20);
                    Console.Write("CHOOSE INDEX: ");
                    int n = int.Parse(Console.ReadLine());
                    departures.EditFlight(ref flights, n);
                    departures.ShowScreen();
                    departures.ShowFlights(flights);
                    break;

                case 3:
                    Console.SetCursorPosition(0, 20);
                    Console.WriteLine("                                 ");
                    Console.SetCursorPosition(0, 20);
                    Console.Write("CHOOSE INDEX: ");
                    int ind = int.Parse(Console.ReadLine());
                    departures.EraseFlight(ref flights, ind);
                    departures.ShowScreen();
                    departures.ShowFlights(flights);
                    break;

                default:
                    Console.WriteLine("WRONG OPTION! Press any key to continue...");
                    Console.ReadLine();
                    departures.ShowScreen();
                    departures.ShowFlights(arrivalsInfo);
                    break;
            }
        }
    }
}
