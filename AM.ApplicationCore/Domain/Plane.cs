using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{ public enum PlaneType
    {
        doing,Airbus
    }
    public class Plane
    {
        public Plane()
        {
        }

        public Plane(int planeId, int capacity, DateTime manufactureDate, PlaneType planeType, IList<Flight> flights)
        {
            PlaneId = planeId;
            Capacity = capacity;
            ManufactureDate = manufactureDate;
            PlaneType = planeType;
            Flights = flights;
        }
        public Plane(PlaneType planeType, int capacity, DateTime manufactureDate)
        {
            Capacity = capacity;
            ManufactureDate = manufactureDate;
            PlaneType = planeType;
        }
        public override string ToString()
        {
            return $"PlaneID: {PlaneId}, Capacity: {Capacity}, ManufactureDate: {ManufactureDate}, PlaneType: {PlaneType}";
        }

        public int PlaneId { get; set; }
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public PlaneType PlaneType { get; set; }
         public IList<Flight> Flights { get; set; }
    }
}
