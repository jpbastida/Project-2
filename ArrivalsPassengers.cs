using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject
{
    public class ArrivalsPassengers : IAirlinePassengers
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
            Console.WriteLine(Titles.TitleArrivals);
            MakeLine(0, 3);
            Console.SetCursorPosition(0, 4);
            Console.Write(dataStr.MenuArrivals);

            Console.SetCursorPosition(0, 5);
            for (int i = 0; i < dataStr.HeadPassengers.Length; i++)
            {
                Console.CursorLeft = positionsHeaders[i];
                Console.Write(dataStr.HeadPassengers[i]);
            }
        }

        public void ShowPassengers(List<Passengers> arrivalsPassengers, string FlightNumber)
        {
            Console.SetCursorPosition(0, 7);
            for (int i = 0; i < arrivalsPassengers.Count; i++)
            {
                if (arrivalsPassengers[i].Flight == FlightNumber)
                {
                    Console.CursorLeft = 40;
                    Console.Write(arrivalsPassengers[i].FirstName);
                    Console.CursorLeft = 50;
                    Console.Write(arrivalsPassengers[i].Surname);
                    Console.CursorLeft = 60;
                    Console.Write(arrivalsPassengers[i].Nationality);
                    Console.CursorLeft = 78;
                    Console.Write(arrivalsPassengers[i].Passport);
                    Console.CursorLeft = 90;
                    Console.Write(arrivalsPassengers[i].Birthday);
                    Console.CursorLeft = 101;
                    Console.Write(arrivalsPassengers[i].Sex);
                    Console.CursorLeft = 108;
                    Console.Write(arrivalsPassengers[i].Ticket);
                    Console.CursorLeft = 120;
                    Console.Write(arrivalsPassengers[i].Class);
                    Console.CursorLeft = 140;
                    Console.Write(arrivalsPassengers[i].PayedPrice);
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public void ShowPassengers(List<Passengers> arrivalsPassengers)
        {
            Console.SetCursorPosition(0, 7);
            for (int i = 0; i < arrivalsPassengers.Count; i++)
            {
                    Console.CursorLeft = 35;
                    Console.Write($"{i + 1}: ");
                    Console.CursorLeft = 40;
                    Console.Write(arrivalsPassengers[i].FirstName);
                    Console.CursorLeft = 50;
                    Console.Write(arrivalsPassengers[i].Surname);
                    Console.CursorLeft = 60;
                    Console.Write(arrivalsPassengers[i].Nationality);
                    Console.CursorLeft = 78;
                    Console.Write(arrivalsPassengers[i].Passport);
                    Console.CursorLeft = 90;
                    Console.Write(arrivalsPassengers[i].Birthday);
                    Console.CursorLeft = 101;
                    Console.Write(arrivalsPassengers[i].Sex);
                    Console.CursorLeft = 108;
                    Console.Write(arrivalsPassengers[i].Ticket);
                    Console.CursorLeft = 120;
                    Console.Write(arrivalsPassengers[i].Class);
                    Console.CursorLeft = 140;
                    Console.Write(arrivalsPassengers[i].PayedPrice);
                    Console.WriteLine();
                    Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public void AddPassenger(ref List<Passengers> arrivalsPassengers)
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
            arrivalsPassengers.Add(new Passengers()
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

        public void EditPassenger(ref List<Passengers> arrivalsPassengers, int index)
        {
            DataStrings dataStr = new DataStrings();

            Console.SetCursorPosition(0, 20);
            Console.WriteLine("                               ");
            Console.SetCursorPosition(0, 20);
            Console.WriteLine($"{dataStr.PassengersToAdd[0]}: ");
            arrivalsPassengers[index - 1].Flight = Console.ReadLine();
            Console.WriteLine($"{dataStr.PassengersToAdd[1]}: ");
            arrivalsPassengers[index - 1].FirstName = Console.ReadLine();
            Console.WriteLine($"{dataStr.PassengersToAdd[2]}: ");
            arrivalsPassengers[index - 1].Surname = Console.ReadLine();
            Console.WriteLine($"{dataStr.PassengersToAdd[3]}: ");
            arrivalsPassengers[index - 1].Nationality = Console.ReadLine();
            Console.WriteLine($"{dataStr.PassengersToAdd[4]}: ");
            arrivalsPassengers[index - 1].Passport = Console.ReadLine();
            Console.WriteLine($"{dataStr.PassengersToAdd[5]}: ");
            arrivalsPassengers[index - 1].Birthday = Console.ReadLine();
            Console.WriteLine($"{dataStr.PassengersToAdd[6]}: ");
            arrivalsPassengers[index - 1].Sex = Console.ReadLine();
            Console.WriteLine($"{dataStr.PassengersToAdd[7]}: ");
            arrivalsPassengers[index - 1].Ticket = Console.ReadLine();
            Console.WriteLine($"{dataStr.PassengersToAdd[8]}: ");
            arrivalsPassengers[index - 1].Class = Console.ReadLine();
            Console.WriteLine($"{dataStr.PassengersToAdd[9]}: ");
            arrivalsPassengers[index - 1].PayedPrice = Console.ReadLine();
        }

        public void ErasePassenger(ref List<Passengers> arrivalsPassengers, int index)
        {
            arrivalsPassengers.RemoveAt(index - 1);
        }

        public void SearchPassenger(List<Passengers> arrivalsPassengers, string passenger)
        {
            int index = 0;
            if (arrivalsPassengers.Any(str => str.FirstName.Contains(passenger)))
            {
                index = arrivalsPassengers.FindIndex(x => x.FirstName.Contains(passenger));
            }
            else if(arrivalsPassengers.Any(str => str.Surname.Contains(passenger)))
            {
                index = arrivalsPassengers.FindIndex(x => x.Surname.Contains(passenger));
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("No results! Press any key to return...");
                Console.ReadLine();
                ShowPassengersHeaders();
                ShowPassengers(arrivalsPassengers);
                return;
            }

            List<Passengers> searchResult = new List<Passengers> {
                    new Passengers { Flight = arrivalsPassengers[index].Flight, FirstName = arrivalsPassengers[index].FirstName,   Surname = arrivalsPassengers[index].Surname,
                        Nationality = arrivalsPassengers[index].Nationality, Passport = arrivalsPassengers[index].Passport, Birthday = arrivalsPassengers[index].Birthday,
                    Sex = arrivalsPassengers[index].Sex, Ticket = arrivalsPassengers[index].Ticket, Class = arrivalsPassengers[index].Class,
                        PayedPrice = arrivalsPassengers[index].PayedPrice} };

            ShowPassengersHeaders();
            ShowPassengers(searchResult);
        }

        public void SearchPassport(List<Passengers> arrivalsPassengers, string passport)
        {
            int index = 0;
            bool passFound = false;

            var match = arrivalsPassengers.Find(st => st.Passport.Contains(passport));
            for (int i = 0; i < arrivalsPassengers.Count; i++)
            {
                if (arrivalsPassengers[i].Passport == passport)
                {
                    index = i;
                    passFound = true;
                }
            }
            if(!passFound)
            {
                Console.WriteLine();
                Console.WriteLine("No results! Press any key to return...");
                Console.ReadLine();
                ShowPassengersHeaders();
                ShowPassengers(arrivalsPassengers);
                return;
            }

            List<Passengers> searchResult = new List<Passengers>
            {
                    new Passengers { Flight = arrivalsPassengers[index].Flight, FirstName = arrivalsPassengers[index].FirstName,
                        Surname = arrivalsPassengers[index].Surname, Nationality = arrivalsPassengers[index].Nationality,
                        Passport = arrivalsPassengers[index].Passport, Birthday = arrivalsPassengers[index].Birthday,
                        Sex = arrivalsPassengers[index].Sex, Ticket = arrivalsPassengers[index].Ticket,
                        Class = arrivalsPassengers[index].Class, PayedPrice = arrivalsPassengers[index].PayedPrice }
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
