using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using Microsoft.VisualBasic;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight : IserviceFlight
    {
        public List<Flight> ListFlights { get; set; } = new List<Flight>();

        public List<DateTime> DateTimes (string d)
        {
            List<DateTime> list = new List<DateTime>();

            for (int i=0;i<ListFlights.Count;i++)
            {
                if (ListFlights[i].Destination == d)
                {
                    list.Add(ListFlights[i].FlightDate);
                }
            }
            return list;
        }
        public IEnumerable<DateTime> DateTimes2(string d)
        {

            foreach (Flight flight in ListFlights)
            {
                if (flight.Destination == d)
                {
                    yield return flight.FlightDate;
                }
            }
        }

      

        public void GetFlights (string filtervalue,Func<string,Flight,Boolean> func)
        {
            Func<string,Flight,Boolean>? condition = null;
            foreach (var item in ListFlights)
            {
                if (condition(filtervalue,item))
                {
                    Console.WriteLine(item);
                }
            }
        }

        public IList<DateTime> GetFlightDates (string destination) {
            // var query = from f in ListFlights
            //            where f.Destination == destination
            //           select f.FlightDate;
            //return query.ToList();
            var query = ListFlights
                .Where(f => f.Destination == destination)
                .Select(f => f.FlightDate);
            return query.ToList();


        }

  

        public void ShowFlightDetails(Plane plane)
        {
            var query = from f in ListFlights
                        where (f.plane == plane)
                        select new { f.FlightDate, f.Destination };

        }
        public int ProgrammedFlightNumber(DateTime startDate)
        {
            return ListFlights.Where(f=> f.FlightDate> startDate && (f.FlightDate-startDate).TotalDays<7).Count();        }
        public float DurationAverage(string destination)
        {
            var query =ListFlights.Where(f=> f.Destination == destination ).Average(f=>f.EstimatedDuration);
            return query;
        }
        public IList<Flight> OrdedDuratinFlight()
        {
            var query = from f in ListFlights
                      orderby f.EstimatedDuration descending
                      select f;
            return query.ToList();
        }
        public IList<Passenger> SeniorTravellers(Flight flight)
        {
            var query = (from f in ListFlights where f.FlightId == flight.FlightId select f).Single();
            return (IList<Passenger>)query.Passengers.OfType<Traveller>().ToList().OrderBy(p=>p.BirthDate).Take(3).ToList();

        }
        public IList<IGrouping<String, Flight> >DestinationGroupeFlight()
        {
            var req= ListFlights.GroupBy(f => f.Destination).ToList();
         foreach (var item in req) { Console.WriteLine("destination "+item.Key); 
            foreach(var item2 in item)
                {
                    Console.WriteLine("decollage"+ item2.FlightDate.ToString());
                }
            }
         return req;
        }
        Action<Plane> FlightDetailDel;
        Func<string,double> DurationAverageDel;
        public ServiceFlight()
        {
            
        }

    }
}
