using Car_park;
using System.Diagnostics.Metrics;

Car Four_seat = new _4seat();
Four_seat.Inputinformation(); Console.Write("\n");
Four_seat.CarInfo();
Four_seat.Bill();
_4seat spot = new _4seat();
PrintTypes(spot);

void PrintTypes(_4seat spot)
{

}

Console.Write("-----------------\n");
Console.Write("\n");

Car Seven_seat = new _7seat();
Seven_seat.Inputinformation(); Console.Write("\n");
Seven_seat.CarInfo();
Seven_seat.Bill();
Console.Write("-----------------\n");
Console.Write("\n");

Car truck = new Truck();
truck.Inputinformation();
truck.CarInfo();
truck.Bill();

