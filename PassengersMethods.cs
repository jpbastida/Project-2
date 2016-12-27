using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject
{
    public class PassengersMethods
    {
        public void ShowPassengers(List<Passengers> listPassengers, string FlightNumber)
        {
            Console.SetCursorPosition(0, 7);
            for (int i = 0; i < listPassengers.Count; i++)
            {
                if (listPassengers[i].Flight == FlightNumber)
                {
                    Console.CursorLeft = 40;
                    Console.Write(listPassengers[i].FirstName);
                    Console.CursorLeft = 50;
                    Console.Write(listPassengers[i].Surname);
                    Console.CursorLeft = 60;
                    Console.Write(listPassengers[i].Nationality);
                    Console.CursorLeft = 78;
                    Console.Write(listPassengers[i].Passport);
                    Console.CursorLeft = 90;
                    Console.Write(listPassengers[i].Birthday);
                    Console.CursorLeft = 101;
                    Console.Write(listPassengers[i].Sex);
                    Console.CursorLeft = 108;
                    Console.Write(listPassengers[i].Ticket);
                    Console.CursorLeft = 120;
                    Console.Write(listPassengers[i].Class);
                    Console.CursorLeft = 140;
                    Console.Write(listPassengers[i].PayedPrice);
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public void ShowPassengers(List<Passengers> listPassengers)
        {
            Console.SetCursorPosition(0, 7);
            for (int i = 0; i < listPassengers.Count; i++)
            {
                Console.CursorLeft = 35;
                Console.Write($"{i + 1}: ");
                Console.CursorLeft = 40;
                Console.Write(listPassengers[i].FirstName);
                Console.CursorLeft = 50;
                Console.Write(listPassengers[i].Surname);
                Console.CursorLeft = 60;
                Console.Write(listPassengers[i].Nationality);
                Console.CursorLeft = 78;
                Console.Write(listPassengers[i].Passport);
                Console.CursorLeft = 90;
                Console.Write(listPassengers[i].Birthday);
                Console.CursorLeft = 101;
                Console.Write(listPassengers[i].Sex);
                Console.CursorLeft = 108;
                Console.Write(listPassengers[i].Ticket);
                Console.CursorLeft = 120;
                Console.Write(listPassengers[i].Class);
                Console.CursorLeft = 140;
                Console.Write(listPassengers[i].PayedPrice);
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public void AddPassenger(ref List<Passengers> listPassengers)
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
            listPassengers.Add(new Passengers()
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

        public void EditPassenger(ref List<Passengers> listPassengers, int index)
        {
            DataStrings dataStr = new DataStrings();

            Console.SetCursorPosition(0, 20);
            Console.WriteLine("                               ");
            Console.SetCursorPosition(0, 20);
            Console.WriteLine($"{dataStr.PassengersToAdd[0]}: ");
            listPassengers[index - 1].Flight = Console.ReadLine();
            Console.WriteLine($"{dataStr.PassengersToAdd[1]}: ");
            listPassengers[index - 1].FirstName = Console.ReadLine();
            Console.WriteLine($"{dataStr.PassengersToAdd[2]}: ");
            listPassengers[index - 1].Surname = Console.ReadLine();
            Console.WriteLine($"{dataStr.PassengersToAdd[3]}: ");
            listPassengers[index - 1].Nationality = Console.ReadLine();
            Console.WriteLine($"{dataStr.PassengersToAdd[4]}: ");
            listPassengers[index - 1].Passport = Console.ReadLine();
            Console.WriteLine($"{dataStr.PassengersToAdd[5]}: ");
            listPassengers[index - 1].Birthday = Console.ReadLine();
            Console.WriteLine($"{dataStr.PassengersToAdd[6]}: ");
            listPassengers[index - 1].Sex = Console.ReadLine();
            Console.WriteLine($"{dataStr.PassengersToAdd[7]}: ");
            listPassengers[index - 1].Ticket = Console.ReadLine();
            Console.WriteLine($"{dataStr.PassengersToAdd[8]}: ");
            listPassengers[index - 1].Class = Console.ReadLine();
            Console.WriteLine($"{dataStr.PassengersToAdd[9]}: ");
            listPassengers[index - 1].PayedPrice = Console.ReadLine();
        }

        public void ErasePassenger(ref List<Passengers> listPassengers, int index)
        {
            listPassengers.RemoveAt(index - 1);
        }

        public void SearchPassenger(List<Passengers> listPassengers, string passenger)
        {
            int index = 0;
            if (listPassengers.Any(str => str.FirstName.Contains(passenger)))
            {
                index = listPassengers.FindIndex(x => x.FirstName.Contains(passenger));
            }
            else if (listPassengers.Any(str => str.Surname.Contains(passenger)))
            {
                index = listPassengers.FindIndex(x => x.Surname.Contains(passenger));
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("No results! Press any key to return...");
                Console.ReadLine();
                if (Program.InArrivals)
                {
                    ArrivalsPassengers passengersArrivals = new ArrivalsPassengers();
                    passengersArrivals.ShowPassengersHeaders();
                }
                else
                {
                    DeparturesPassengers passengersArrivals = new DeparturesPassengers();
                    passengersArrivals.ShowPassengersHeaders();
                }
                ShowPassengers(listPassengers);
                return;
            }

            List<Passengers> searchResult = new List<Passengers> {
                    new Passengers { Flight = listPassengers[index].Flight, FirstName = listPassengers[index].FirstName,   Surname = listPassengers[index].Surname,
                        Nationality = listPassengers[index].Nationality, Passport = listPassengers[index].Passport, Birthday = listPassengers[index].Birthday,
                    Sex = listPassengers[index].Sex, Ticket = listPassengers[index].Ticket, Class = listPassengers[index].Class,
                        PayedPrice = listPassengers[index].PayedPrice} };
            SelectKindOfPassengers();
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
            if (!passFound)
            {
                Console.WriteLine();
                Console.WriteLine("No results! Press any key to return...");
                Console.ReadLine();
                SelectKindOfPassengers();
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
            SelectKindOfPassengers();
            ShowPassengers(searchResult);
        }

        private static void SelectKindOfPassengers()
        {
            if (Program.InArrivals)
            {
                ArrivalsPassengers passengersArrivals = new ArrivalsPassengers();
                passengersArrivals.ShowPassengersHeaders();
            }
            else
            {
                DeparturesPassengers passengersDepartures = new DeparturesPassengers();
                passengersDepartures.ShowPassengersHeaders();
            }
        }

        public void MakeLine(int XPos, int YPos)
        {
            Console.SetCursorPosition(XPos, YPos);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("_");
            }
        }
    }
}
