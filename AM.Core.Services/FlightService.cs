using System.Collections;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using AM.Core.Domain;

namespace AM.Core.Services
{
    public class FlightService:IFlightService
    {
        public IList<Flight> Flights { get; set; }

        public IList<DateTime> GetFlightDates(string destination)
        {
          //  List<DateTime> dates= new List<DateTime>();
          //  foreach(var flight in Flights)
          //  {
          //      if (flight.Destination == destination) {
          //
          //          dates.Add(flight.FlightDate);
          //      }
          //  }
          //  return dates;
                    // tp2
                     // linQ integré 
            return (from flight in Flights
                   where flight.Destination == destination
                   select flight.FlightDate).ToList();

       
        }

        public IEnumerable<object> ShowFlightDetails(Plane plane)
        {
            return Flights.Where(e => e.MyPlane == plane).Select(e => new { e.Destination, e.FlightDate });
        }

        public int GetWeeklyFlightNumber(DateTime date)
        {
            return Flights.Where(e=>e.FlightDate < date.AddDays(7)).Count();
        }

        public double GetDurationAverage(String destination)
        {
            return Flights.Where(e => e.Destination == destination).Select(e => e.EstimatedDuration).Average();
        }

        public IEnumerable<object> SortFlights() { 
            return Flights.OrderByDescending(e => e.EstimatedDuration);
        }

        public IEnumerable<object> GetThreeOlderTravellers(Flight vol)
        {
            var nbpassenger = vol.Passengers.OrderBy(e => e.Age);
            return nbpassenger.Take(3);
        }

        public IEnumerable<object> ShowGroupedFlights()
        {
            return Flights.GroupBy(e => e.Destination);
        }
       public void GetFlights(string filterType, string filterValue)
        {

            switch (filterType)
            {
                case "Destination":
                    foreach (var flight in Flights)
                    {
                        if(flight.Destination == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;

                case "Departure":
                    foreach (var flight in Flights)
                    {
                        if (flight.Departure == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;

                case "FlightDate":
                    foreach (var flight in Flights)
                    {
                        if (flight.FlightDate.ToString() == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;

                case "FlightId":
                    foreach (var flight in Flights)
                    {
                        if (flight.FlightId.ToString() == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;

                case "EffectiveArrival":
                    foreach (var flight in Flights)
                    {
                        if (flight.EffectiveArrival.ToString() == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;

                case "EstimatedDuration":
                    foreach (var flight in Flights)
                    {
                        if (flight.EstimatedDuration.ToString() == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;

                default:
                    Console.WriteLine("ERROR");
                    break;

            }
        }
    }
}