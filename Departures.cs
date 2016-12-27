using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject
{
    public class Departures : FlightMethods
    {
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
                Console.CursorLeft = FlightMethods.Positions[i];
                Console.Write(dataStr.HeadTags[i]);
            }
        }
    }
}
