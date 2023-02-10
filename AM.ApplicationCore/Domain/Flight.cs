using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public Flight()
        {
        }

        public Flight(string destination, string departure, DateTime flightDate, int flightId, int effectiveArrival, int estimationDuration, Plane plane, IList<Passenger> passes)
        {
            Destination = destination;
            Departure = departure;
            FlightDate = flightDate;
            FlightId = flightId;
            EffectiveArrival = effectiveArrival;
            EstimationDuration = estimationDuration;
            Plane = plane;
            Passes = passes;
        }
        public override string ToString()
        {
            return $"FlightId: {FlightId}, Destination: {Destination}, Departure: {Departure}, FlightDate: {FlightDate}, EffectiveArrival: {EffectiveArrival}, EstimatedDuration: {EstimationDuration}";
        }

        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate { get; set; }

        public int FlightId { get; set;}
        public int EffectiveArrival { get; set; }
        public int EstimationDuration { get; set; }
        public Plane Plane { get; set; }
        public IList<Passenger> Passes { get; set; }


    }
}
