using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject
{
    public class ArrivalsPassengers : PassengersMethods
    {
        public void ShowPassengersHeaders()
        {
            int[] positionsHeaders = { 40, 50, 60, 78, 90, 100, 110, 120, 140 };
            Console.Clear();
            DataStrings dataStr = new DataStrings();

            Titles Titles = new Titles("AIRLINE INFORMATION", "DEPARTURES", "ARRIVALS");
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
    }
}
