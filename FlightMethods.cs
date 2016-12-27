using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject
{
    public class FlightMethods
    {
        public static readonly int[] Positions = { 50, 70, 90, 110, 120, 140, 150 };

        public void ShowFlights(List<Flights> dataFlights)
        {
            Console.SetCursorPosition(0, 7);
            for (int i = 0; i < dataFlights.Count; i++)
            {
                if (dataFlights[i].DataFlight != null)
                {
                    Console.CursorLeft = 38;
                    Console.Write($"{i + 1}: ");
                    Console.CursorLeft = 45;
                    DateTime date = (DateTime)dataFlights[i].DataFlight;
                    Console.Write(date.ToString("HH:mm dd/MM/yyyy"));
                    Console.CursorLeft = 70;
                    Console.Write(dataFlights[i].Flight);
                    Console.CursorLeft = 89;
                    Console.Write(dataFlights[i].City);
                    Console.CursorLeft = 113;
                    Console.Write(dataFlights[i].Terminal);
                    Console.CursorLeft = 121;
                    Console.Write(dataFlights[i].Gate);
                    Console.CursorLeft = 140;
                    Console.Write(dataFlights[i].Status);
                    Console.CursorLeft = 150;
                    Console.Write($"${dataFlights[i].Price}");
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public void AddFlight(ref List<Flights> dataFlights)
        {
            DataStrings dataStr = new DataStrings();
            string[] toAddFlight = new string[7];

            for (int i = 1; i < 7; i++)
            {
                Console.SetCursorPosition(0, 20);
                Console.WriteLine("                            ");
                Console.SetCursorPosition(0, 20);
                Console.Write($"{dataStr.HeadTags[i]}: ");
                toAddFlight[i] = Console.ReadLine();
            }
            dataFlights.Add(new Flights()
            {
                DataFlight = DateTime.Now,
                Flight = toAddFlight[1],
                City = toAddFlight[2],
                Terminal = toAddFlight[3],
                Gate = toAddFlight[4],
                Status = toAddFlight[5],
                Price = toAddFlight[6]
            });
        }

        public void EditFlight(ref List<Flights> arrivalsFlights, int index)
        {
            DataStrings dataStr = new DataStrings();

            Console.SetCursorPosition(0, 20);
            Console.WriteLine("                               ");
            Console.SetCursorPosition(0, 20);
            arrivalsFlights[index - 1].DataFlight = DateTime.Now;
            Console.WriteLine($"{dataStr.HeadTags[1]}: ");
            arrivalsFlights[index - 1].Flight = Console.ReadLine();
            Console.WriteLine($"{dataStr.HeadTags[2]}: ");
            arrivalsFlights[index - 1].City = Console.ReadLine();
            Console.WriteLine($"{dataStr.HeadTags[3]}: ");
            arrivalsFlights[index - 1].Terminal = Console.ReadLine();
            Console.WriteLine($"{dataStr.HeadTags[4]}: ");
            arrivalsFlights[index - 1].Gate = Console.ReadLine();
            Console.WriteLine($"{dataStr.HeadTags[5]}: ");
            arrivalsFlights[index - 1].Status = Console.ReadLine();
            Console.WriteLine($"{dataStr.HeadTags[6]}: ");
            arrivalsFlights[index - 1].Price = Console.ReadLine();
        }

        public void EraseFlight(ref List<Flights> arrivalsFlights, int index)
        {
            arrivalsFlights.RemoveAt(index - 1);
        }

        public void SearchFlight(List<Flights> arrivalsFlights, string flight)
        {
            int index = 0;
            if (arrivalsFlights.Any(str => str.Flight.Contains(flight)))
            {
                index = arrivalsFlights.FindIndex(x => x.Flight.Contains(flight));
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("No results! Press any key to return...");
                Console.ReadLine();
                if (Program.InArrivals)
                {
                    Arrivals listArrivals = new Arrivals();
                    listArrivals.ShowScreen();
                }
                else
                {
                    Departures listDepartures = new Departures();
                    listDepartures.ShowScreen();
                }
                ShowFlights(arrivalsFlights);
                return;
            }

            List<Flights> searchResult = new List<Flights> {
                    new Flights { DataFlight = arrivalsFlights[index].DataFlight, Flight = arrivalsFlights[index].Flight,
                        City = arrivalsFlights[index].City, Terminal = arrivalsFlights[index].Terminal,
                        Gate = arrivalsFlights[index].Gate, Status = arrivalsFlights[index].Status,
                        Price = arrivalsFlights[index].Price } };
            if (Program.InArrivals)
            {
                Arrivals listArrivals = new Arrivals();
                listArrivals.ShowScreen();
            }
            else
            {
                Departures listDepartures = new Departures();
                listDepartures.ShowScreen();
            }
            ShowFlights(searchResult);
        }

        public void SearchCheapest(List<Flights> arrivalsFlights)
        {
            string cheapestPrice = arrivalsFlights.Min(p => p.Price);
            int index = 0;
            if (arrivalsFlights.Any(str => str.Price.Contains(cheapestPrice)))
            {
                index = arrivalsFlights.FindIndex(x => x.Price.Contains(cheapestPrice));
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("No results! Press any key to return...");
                Console.ReadLine();
                if (Program.InArrivals)
                {
                    Arrivals listArrivals = new Arrivals();
                    listArrivals.ShowScreen();
                }
                else
                {
                    Departures listDepartures = new Departures();
                    listDepartures.ShowScreen();
                }
                ShowFlights(arrivalsFlights);
                return;
            }

            List<Flights> searchResult = new List<Flights> {
                    new Flights { DataFlight = arrivalsFlights[index].DataFlight, Flight = arrivalsFlights[index].Flight,
                        City = arrivalsFlights[index].City, Terminal = arrivalsFlights[index].Terminal,
                        Gate = arrivalsFlights[index].Gate, Status = arrivalsFlights[index].Status,
                        Price = arrivalsFlights[index].Price } };
            if (Program.InArrivals)
            {
                Arrivals listArrivals = new Arrivals();
                listArrivals.ShowScreen();
            }
            else
            {
                Departures listDepartures = new Departures();
                listDepartures.ShowScreen();
            }
            ShowFlights(searchResult);
        }

        public static void MakeLine(int XPos, int YPos)
        {
            Console.SetCursorPosition(XPos, YPos);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("_");
            }
        }
    }
}
