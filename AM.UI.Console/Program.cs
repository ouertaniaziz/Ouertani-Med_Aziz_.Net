// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;

Console.WriteLine("Hello, World!");
PlaneType planeType=PlaneType.doing;
Plane  plane= new Plane();
Plane plane1= new(planeType, 12,DateTime.Now);

Passenger   p= new Passenger();
p.PassengerType();
 Staff staff= new Staff();
staff.PassengerType();
Traveller traveller =new Traveller();
traveller.PassengerType();