// See https://aka.ms/new-console-template for more information
using AM.Core.Domain;

Console.WriteLine("Hello, World!");
//TP 1.Question7
Plane plane= new Plane();
plane.Capacity = 300;
plane.ManufactureDate = new DateTime(2000, 1, 1);
plane.MyPlaneType = PlaneType.Boeing;
//TP 1.Question8
Plane plane1 = new Plane(PlaneType.Airbus, 100, new DateTime(2001, 9, 12));
//TP 1.Question9
Plane plane2 = new Plane()
{
    Capacity = 100,
    ManufactureDate = new DateTime(2011, 2, 14)
};
//TP1.Question12.B
Passenger passenger = new Passenger();
Passenger staff =new Staff();
Passenger traveller = new Traveller();
Console.WriteLine(passenger.GetPassengerType());
Console.WriteLine(staff.GetPassengerType());
Console.WriteLine(traveller.GetPassengerType());
//TP1.Question13.C
int calculatedAge = 0;
passenger.GetAge(new DateTime(2000, 1, 1), ref calculatedAge);
Console.WriteLine(calculatedAge);
passenger.BirthDate = new DateTime(2000, 1, 1);
//passenger.GetAge(passenger);
//Console.WriteLine(passenger.Age);


