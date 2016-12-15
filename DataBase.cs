using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject
{
    class DataBase
    {
        protected static List<Flights> arrivalsInfo = new List<Flights> {
            new Flights { DataFlight = DateTime.Parse("12/15/2016 09:05", System.Globalization.CultureInfo.InvariantCulture),
                Flight = "KL9260", City = "MUNICH", Terminal = "D", Gate = "G5", Status = "UNKNOWN", Price = "1200" },
            new Flights { DataFlight = DateTime.Parse("12/15/2016 10:15", System.Globalization.CultureInfo.InvariantCulture),
                Flight = "KL8518", City = "PARIS", Terminal = "A", Gate = "A11", Status = "ONTIME", Price = "1700" },
        };

        protected static List<Flights> departuresInfo = new List<Flights> {
            new Flights { DataFlight = DateTime.Parse("12/22/2016 14:15", System.Globalization.CultureInfo.InvariantCulture),
                Flight = "KL7766", City = "MADRID", Terminal = "F", Gate = "A5", Status = "UNKNOWN", Price = "1750" },
            new Flights { DataFlight = DateTime.Parse("12/23/2016 16:45", System.Globalization.CultureInfo.InvariantCulture),
                Flight = "KL3344", City = "LONDON", Terminal = "C", Gate = "B7", Status = "ONTIME", Price = "1570" },
        };

        protected static List<Passengers> passengersArrivals = new List<Passengers> {
            new Passengers { Flight = "KL9260", FirstName = "JOHN",   Surname = "CORN", Nationality = "USA", Passport = "G203", Birthday = "01/07/1967",
                    Sex = "MALE", Ticket = "TK12421514", Class = "ECONOMY", PayedPrice = "1200.00" },
            new Passengers { Flight = "KL8518", FirstName = "FAME",   Surname = "COBAIN", Nationality = "CANADA", Passport = "F2456", Birthday = "04/05/1979",
                    Sex = "MALE", Ticket = "TK134245665", Class = "BUSSINESS", PayedPrice = "5400.00" },
            new Passengers { Flight = "KL9260", FirstName = "VINCENT",   Surname = "PASCAL", Nationality = "FRANCE", Passport = "T233", Birthday = "14/04/1971",
                    Sex = "MALE", Ticket = "TK12428514", Class = "ECONOMY", PayedPrice = "1350.00" },
            new Passengers { Flight = "KL8518", FirstName = "SAM",   Surname = "KUTE", Nationality = "ENGLAND", Passport = "P245", Birthday = "11/09/1977",
                    Sex = "MALE", Ticket = "TK11221514", Class = "ECONOMY", PayedPrice = "1200.00" },
            new Passengers { Flight = "KL9260", FirstName = "CELINE",   Surname = "DION", Nationality = "CANADA", Passport = "F2456", Birthday = "04/05/1979",
                    Sex = "FEMALE", Ticket = "TK177245665", Class = "BUSSINESS", PayedPrice = "5400.00" },
            new Passengers { Flight = "KL8518", FirstName = "MONICA",   Surname = "TORRES", Nationality = "SPAIN", Passport = "E2333", Birthday = "22/04/1980",
                    Sex = "FEMALE", Ticket = "TK12495514", Class = "ECONOMY", PayedPrice = "1350.00" },
        };

        protected static List<Passengers> passengersDepartures = new List<Passengers> {
            new Passengers { Flight = "KL7766", FirstName = "ROGER",   Surname = "PERRK", Nationality = "USA", Passport = "G203", Birthday = "01/07/1967",
                    Sex = "MALE", Ticket = "TK12421514", Class = "ECONOMY", PayedPrice = "1200.00" },
            new Passengers { Flight = "KL3344", FirstName = "GEORGE",   Surname = "CULTO", Nationality = "CANADA", Passport = "F2456", Birthday = "04/05/1979",
                    Sex = "MALE", Ticket = "TK134245665", Class = "BUSSINESS", PayedPrice = "5400.00" },
            new Passengers { Flight = "KL7766", FirstName = "ALFRED",   Surname = "PERNS", Nationality = "FRANCE", Passport = "T233", Birthday = "14/04/1971",
                    Sex = "MALE", Ticket = "TK12428514", Class = "ECONOMY", PayedPrice = "1350.00" },
            new Passengers { Flight = "KL3344", FirstName = "SAMUEL",   Surname = "LINES", Nationality = "ENGLAND", Passport = "P245", Birthday = "11/09/1977",
                    Sex = "MALE", Ticket = "TK11221514", Class = "ECONOMY", PayedPrice = "1200.00" },
            new Passengers { Flight = "KL7766", FirstName = "CECILIA",   Surname = "SAINS", Nationality = "CANADA", Passport = "F2456", Birthday = "04/05/1979",
                    Sex = "FEMALE", Ticket = "TK177245665", Class = "BUSSINESS", PayedPrice = "5400.00" },
            new Passengers { Flight = "KL3344", FirstName = "REIK",   Surname = "PEREZ", Nationality = "SPAIN", Passport = "E2333", Birthday = "22/04/1980",
                    Sex = "FEMALE", Ticket = "TK12495514", Class = "ECONOMY", PayedPrice = "1350.00" },
        };
    }
}
