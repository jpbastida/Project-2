using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject
{
    public class DeparturesPassengers : IAirlinePassengers
    {
        int[] positionsHeaders = { 40, 50, 60, 78, 90, 100, 110, 120, 140 };

        public void ShowPassengersHeaders()
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
            for (int i = 0; i < dataStr.HeadPassengers.Length; i++)
            {
                Console.CursorLeft = positionsHeaders[i];
                Console.Write(dataStr.HeadPassengers[i]);
            }
        }

        public void ShowPassengers(List<Passengers> departuresPassengers, string FlightNumber)
        {
            Console.SetCursorPosition(0, 7);
            for (int i = 0; i < departuresPassengers.Count; i++)
            {
                if (departuresPassengers[i].Flight == FlightNumber)
                {
                    Console.CursorLeft = 40;
                    Console.Write(departuresPassengers[i].FirstName);
                    Console.CursorLeft = 50;
                    Console.Write(departuresPassengers[i].Surname);
                    Console.CursorLeft = 60;
                    Console.Write(departuresPassengers[i].Nationality);
                    Console.CursorLeft = 78;
                    Console.Write(departuresPassengers[i].Passport);
                    Console.CursorLeft = 90;
                    Console.Write(departuresPassengers[i].Birthday);
                    Console.CursorLeft = 101;
                    Console.Write(departuresPassengers[i].Sex);
                    Console.CursorLeft = 108;
                    Console.Write(departuresPassengers[i].Ticket);
                    Console.CursorLeft = 120;
                    Console.Write(departuresPassengers[i].Class);
                    Console.CursorLeft = 140;
                    Console.Write(departuresPassengers[i].PayedPrice);
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public void ShowPassengers(List<Passengers> departuresPassengers)
        {
            Console.SetCursorPosition(0, 7);
            for (int i = 0; i < departuresPassengers.Count; i++)
            {
                Console.CursorLeft = 35;
                Console.Write($"{i + 1}: ");
                Console.CursorLeft = 40;
                Console.Write(departuresPassengers[i].FirstName);
                Console.CursorLeft = 50;
                Console.Write(departuresPassengers[i].Surname);
                Console.CursorLeft = 60;
                Console.Write(departuresPassengers[i].Nationality);
                Console.CursorLeft = 78;
                Console.Write(departuresPassengers[i].Passport);
                Console.CursorLeft = 90;
                Console.Write(departuresPassengers[i].Birthday);
                Console.CursorLeft = 101;
                Console.Write(departuresPassengers[i].Sex);
                Console.CursorLeft = 108;
                Console.Write(departuresPassengers[i].Ticket);
                Console.CursorLeft = 120;
                Console.Write(departuresPassengers[i].Class);
                Console.CursorLeft = 140;
                Console.Write(departuresPassengers[i].PayedPrice);
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public void AddPassenger(ref List<Passengers> departuresPassengers)
        {
            DataStrings dataStr = new DataStrings();
            string[] toAddPassenger = new string[10];

            for (int i = 1; i < 10; i++)
            {
                Console.SetCursorPosition(0, 20);
                Console.WriteLine("                            ");
                Console.SetCursorPosition(0, 20);
                Console.Write($"{dataStr.PassengersToAdd[i]}: ");
                toAddPassenger[i] = Console.ReadLine();
            }
            departuresPassengers.Add(new Passengers()
            {
                Flight = toAddPassenger[0],
                FirstName = toAddPassenger[1],
                Surname = toAddPassenger[2],
                Nationality = toAddPassenger[3],
                Passport = toAddPassenger[4],
                Birthday = toAddPassenger[5],
                Sex = toAddPassenger[6],
                Ticket = toAddPassenger[7],
                Class = toAddPassenger[8],
                PayedPrice = toAddPassenger[9],
            });
        }

        public void EditPassenger(ref List<Passengers> departuresPassengers, int index)
        {
            DataStrings dataStr = new DataStrings();

            Console.SetCursorPosition(0, 20);
            Console.WriteLine("                               ");
            Console.SetCursorPosition(0, 20);
            Console.WriteLine($"{dataStr.PassengersToAdd[0]}: ");
            departuresPassengers[index - 1].Flight = Console.ReadLine();
            Console.WriteLine($"{dataStr.PassengersToAdd[1]}: ");
            departuresPassengers[index - 1].FirstName = Console.ReadLine();
            Console.WriteLine($"{dataStr.PassengersToAdd[2]}: ");
            departuresPassengers[index - 1].Surname = Console.ReadLine();
            Console.WriteLine($"{dataStr.PassengersToAdd[3]}: ");
            departuresPassengers[index - 1].Nationality = Console.ReadLine();
            Console.WriteLine($"{dataStr.PassengersToAdd[4]}: ");
            departuresPassengers[index - 1].Passport = Console.ReadLine();
            Console.WriteLine($"{dataStr.PassengersToAdd[5]}: ");
            departuresPassengers[index - 1].Birthday = Console.ReadLine();
            Console.WriteLine($"{dataStr.PassengersToAdd[6]}: ");
            departuresPassengers[index - 1].Sex = Console.ReadLine();
            Console.WriteLine($"{dataStr.PassengersToAdd[7]}: ");
            departuresPassengers[index - 1].Ticket = Console.ReadLine();
            Console.WriteLine($"{dataStr.PassengersToAdd[8]}: ");
            departuresPassengers[index - 1].Class = Console.ReadLine();
            Console.WriteLine($"{dataStr.PassengersToAdd[9]}: ");
            departuresPassengers[index - 1].PayedPrice = Console.ReadLine();
        }

        public void ErasePassenger(ref List<Passengers> departuresPassengers, int index)
        {
            departuresPassengers.RemoveAt(index - 1);
        }

        public void SearchPassenger(List<Passengers> departuresPassengers, string passenger)
        {
            int index = 0;
            if (departuresPassengers.Any(str => str.FirstName.Contains(passenger)))
            {
                index = departuresPassengers.FindIndex(x => x.FirstName.Contains(passenger));
            }
            else if (departuresPassengers.Any(str => str.Surname.Contains(passenger)))
            {
                index = departuresPassengers.FindIndex(x => x.Surname.Contains(passenger));
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("No results! Press any key to return...");
                Console.ReadLine();
                ShowPassengersHeaders();
                ShowPassengers(departuresPassengers);
                return;
            }

            List<Passengers> searchResult = new List<Passengers> {
                    new Passengers { Flight = departuresPassengers[index].Flight, FirstName = departuresPassengers[index].FirstName,
                        Surname = departuresPassengers[index].Surname, Nationality = departuresPassengers[index].Nationality,
                        Passport = departuresPassengers[index].Passport, Birthday = departuresPassengers[index].Birthday,
                        Sex = departuresPassengers[index].Sex, Ticket = departuresPassengers[index].Ticket,
                        Class = departuresPassengers[index].Class, PayedPrice = departuresPassengers[index].PayedPrice}
            };

            ShowPassengersHeaders();
            ShowPassengers(searchResult);
        }

        public void SearchPassport(List<Passengers> departuresPassengers, string passport)
        {
            int index = 0;
            bool passFound = false;

            var match = departuresPassengers.Find(st => st.Passport.Contains(passport));
            for (int i = 0; i < departuresPassengers.Count; i++)
            {
                if (departuresPassengers[i].Passport == passport)
                {
                    index = i;
                    passFound = true;
                }
            }
            if (!passFound)
            {
                Console.WriteLine();
                Console.WriteLine("No results! Press any key to return...");
                Console.ReadLine();
                ShowPassengersHeaders();
                ShowPassengers(departuresPassengers);
                return;
            }

            List<Passengers> searchResult = new List<Passengers>
            {
                    new Passengers { Flight = departuresPassengers[index].Flight, FirstName = departuresPassengers[index].FirstName,
                        Surname = departuresPassengers[index].Surname, Nationality = departuresPassengers[index].Nationality,
                        Passport = departuresPassengers[index].Passport, Birthday = departuresPassengers[index].Birthday,
                        Sex = departuresPassengers[index].Sex, Ticket = departuresPassengers[index].Ticket,
                        Class = departuresPassengers[index].Class, PayedPrice = departuresPassengers[index].PayedPrice }
            };

            ShowPassengersHeaders();
            ShowPassengers(searchResult);
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
