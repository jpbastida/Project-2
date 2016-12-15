using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject
{
    public class Departures : IAirlineFlights
    {
        int[] positions = { 50, 70, 90, 110, 120, 140, 150 };

        public void ShowScreen()
        {
            Console.Clear();
            DataStrings dataStr = new DataStrings();

            Titles Titles = new Titles("AIRLINE INFORMATION", "DEPARTURES", "ARRIVALS");
            Console.Clear();
            Console.CursorLeft = (Console.WindowWidth - Titles.Title.Length) / 2;
            Console.WriteLine(Titles.Title);
            MakeLine(0, 1);
            Console.CursorLeft = (Console.WindowWidth - Titles.TitleDepartures.Length) / 2;
            Console.WriteLine(Titles.TitleDepartures);
            MakeLine(0, 3);
            Console.SetCursorPosition(0, 4);
            Console.Write(dataStr.MenuDepartures);

            Console.SetCursorPosition(0, 5);
            for (int i = 0; i < dataStr.HeadTags.Length; i++)
            {
                Console.CursorLeft = positions[i];
                Console.Write(dataStr.HeadTags[i]);
            }
        }

        public void ShowFlights(List<Flights> departuresFlights)
        {
            Console.SetCursorPosition(0, 7);
            for (int i = 0; i < departuresFlights.Count; i++)
            {
                if (departuresFlights[i].DataFlight != null)
                {
                    Console.CursorLeft = 38;
                    Console.Write($"{i + 1}: ");
                    Console.CursorLeft = 45;
                    DateTime date = (DateTime)departuresFlights[i].DataFlight;
                    Console.Write(date.ToString("HH:mm dd/MM/yyyy"));
                    Console.CursorLeft = 70;
                    Console.Write(departuresFlights[i].Flight);
                    Console.CursorLeft = 89;
                    Console.Write(departuresFlights[i].City);
                    Console.CursorLeft = 113;
                    Console.Write(departuresFlights[i].Terminal);
                    Console.CursorLeft = 121;
                    Console.Write(departuresFlights[i].Gate);
                    Console.CursorLeft = 140;
                    Console.Write(departuresFlights[i].Status);
                    Console.CursorLeft = 150;
                    Console.Write($"${departuresFlights[i].Price}");
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public void AddFlight(ref List<Flights> departuresFlights)
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
            departuresFlights.Add(new Flights()
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

        public void EditFlight(ref List<Flights> departuresFlights, int index)
        {
            DataStrings dataStr = new DataStrings();

            Console.SetCursorPosition(0, 20);
            Console.WriteLine("                               ");
            Console.SetCursorPosition(0, 20);
            departuresFlights[index - 1].DataFlight = DateTime.Now;
            Console.WriteLine($"{dataStr.HeadTags[1]}: ");
            departuresFlights[index - 1].Flight = Console.ReadLine();
            Console.WriteLine($"{dataStr.HeadTags[2]}: ");
            departuresFlights[index - 1].City = Console.ReadLine();
            Console.WriteLine($"{dataStr.HeadTags[3]}: ");
            departuresFlights[index - 1].Terminal = Console.ReadLine();
            Console.WriteLine($"{dataStr.HeadTags[4]}: ");
            departuresFlights[index - 1].Gate = Console.ReadLine();
            Console.WriteLine($"{dataStr.HeadTags[5]}: ");
            departuresFlights[index - 1].Status = Console.ReadLine();
            Console.WriteLine($"{dataStr.HeadTags[6]}: ");
            departuresFlights[index - 1].Price = Console.ReadLine();
        }

        public void EraseFlight(ref List<Flights> departuresFlights, int index)
        {
            departuresFlights.RemoveAt(index - 1);
        }

        public void SearchFlight(List<Flights> departuresFlights, string flight)
        {
            int index = 0;
            if (departuresFlights.Any(str => str.Flight.Contains(flight)))
            {
                index = departuresFlights.FindIndex(x => x.Flight.Contains(flight));
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("No results! Press any key to return...");
                Console.ReadLine();
                ShowScreen();
                ShowFlights(departuresFlights);
                return;
            }

            List<Flights> searchResult = new List<Flights> {
                    new Flights { DataFlight = departuresFlights[index].DataFlight, Flight = departuresFlights[index].Flight,
                        City = departuresFlights[index].City, Terminal = departuresFlights[index].Terminal,
                        Gate = departuresFlights[index].Gate, Status = departuresFlights[index].Status,
                        Price = departuresFlights[index].Price } };

            ShowScreen();
            ShowFlights(searchResult);
        }

        public void SearchCheapest(List<Flights> departuresFlights)
        {
            string cheapestPrice = departuresFlights.Min(p => p.Price);
            int index = 0;
            if (departuresFlights.Any(str => str.Price.Contains(cheapestPrice)))
            {
                index = departuresFlights.FindIndex(x => x.Price.Contains(cheapestPrice));
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("No results! Press any key to return...");
                Console.ReadLine();
                ShowScreen();
                ShowFlights(departuresFlights);
                return;
            }

            List<Flights> searchResult = new List<Flights> {
                    new Flights { DataFlight = departuresFlights[index].DataFlight, Flight = departuresFlights[index].Flight,
                        City = departuresFlights[index].City, Terminal = departuresFlights[index].Terminal,
                        Gate = departuresFlights[index].Gate, Status = departuresFlights[index].Status,
                        Price = departuresFlights[index].Price } };

            ShowScreen();
            ShowFlights(searchResult);
        }

        static void MakeLine(int XPos, int YPos)
        {
            Console.SetCursorPosition(XPos, YPos);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("_");
            }
        }
    }
}
