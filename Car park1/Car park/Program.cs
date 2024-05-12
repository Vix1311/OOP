using Car_park;
using System.Security.Cryptography.X509Certificates;


//var carParking = new CarParking();
//var fourSeatA = new FourSeat("1", DateTime.Now);
//carParking.Vehicals.Add(fourSeatA);

//var fourSeatB = new FourSeat("2", DateTime.Now);
//carParking.Vehicals.Add(fourSeatB);

//var sevenSeatA = new SevenSeat("3", DateTime.Now);
//carParking.Vehicals.Add(sevenSeatA);

//var sevenSeatB = new SevenSeat("4", DateTime.Now);
//carParking.Vehicals.Add(sevenSeatB);

//var sevenSeatC = new SevenSeat("5", DateTime.Now);
//carParking.Vehicals.Add(sevenSeatC);

//var truckA = new Truck("6", DateTime.Now);
//carParking.Vehicals.Add(truckA);

//var test = carParking.CountCarType(CarType.Truck);
//Console.WriteLine(test);
static void Inputinformation()
{
    string id;
    var continueLoop = true;
    do
    {
        Console.WriteLine("Welcome to CarPark System.");
        Console.WriteLine("Menu Option:");
        Console.WriteLine("1. Input car information.");
        Console.WriteLine("2. Checkout car.");
        Console.WriteLine("3. Count number in car base on type of car.");
        Console.WriteLine("4. Quit");
        Console.WriteLine("Your Option: ");
        var keyOption = Console.ReadLine();

        int value;
        var isNumber = int.TryParse(keyOption, out value);
        if (isNumber && value > 0 && value < 5)
        {
            continueLoop = false;
            Inputinformation();
        }
        else
        {
            Console.WriteLine("Please press only 1 to 4");
        }

        if (keyOption == "1")
        {
            Console.WriteLine("Please select type of car.");
            Console.WriteLine("1. Four seat.");
            Console.WriteLine("2. Seven sear.");
            Console.WriteLine("3. Truck.");
            Console.WriteLine("4. Return to previous menu.");
            Console.WriteLine("Your Option: ");
            keyOption = Console.ReadLine();
            if (keyOption == "1")
            {
                var vehical = new FourSeat();

                var day = InputDayIn();
                var month = InputMonthIn();
                var year = InputYearIn();
                vehical.TimeIn = new DateTime(year, month, day);
            }
            if (keyOption == "2")
            {
                var vehical = new SevenSeat();

                var day = InputDayIn();
                var month = InputMonthIn();
                var year = InputYearIn();
                vehical.TimeIn = new DateTime(year, month, day);
            }
            if (keyOption == "3")
            {
                var vehical = new Truck();

                var day = InputDayIn();
                var month = InputMonthIn();
                var year = InputYearIn();
                vehical.TimeIn = new DateTime(year, month, day);
            }
            if (keyOption == "4")
            {
                ReturnInputinformation();
            }
        }
        if (keyOption == "2")
        {
            var vehical = new 
            Console.WriteLine("Please input Car ID.");
            id = Console.ReadLine();
            Fine_car(id);
            if (CarType = CarType.FourSeat)
                Console.WriteLine("Out Bill: {0}$", ((DateTime.Now - vehical.TimeIn) * 10));
            if (CarType = CarType.SevenSeat)
                Console.WriteLine("Out Bill: {0}$", ((DateTime.Now - vehical.TimeIn) * 15));
            if (CarType = CarType.Truck)
                Console.WriteLine("Out Bill: {0}$", ((DateTime.Now - vehical.TimeIn) * 20));
        }
        if (keyOption == "3")
        {
            var carParking = new CarParking();
            Console.WriteLine("Please select type of car.");
            Console.WriteLine("1. Four seat.");
            Console.WriteLine("2. Seven sear.");
            Console.WriteLine("3. Truck.");
            keyOption = Console.ReadLine();
            if (keyOption == "1") 
            {
                var count = carParking.CountCarType(CarType.FourSeat);
                Console.WriteLine("The car park have {0} inside", count);
            }
            if (keyOption == "2")
            {
                var count = carParking.CountCarType(CarType.SevenSeat);
                Console.WriteLine("The car park have {0} inside", count);
            }
            if (keyOption == "3")
            {
                var count = carParking.CountCarType(CarType.Truck);
                Console.WriteLine("The car park have {0} inside", count);
            }
        }
        if (keyOption == "4")
        {
            return;
        }

    }
    while (continueLoop);

}

static void Fine_car(string? id)
{
    throw new NotImplementedException();
}
static void ReturnInputinformation()
{
    Inputinformation();
}
static int InputDayIn() { throw new NotImplementedException(); }
static int InputMonthIn() { throw new NotImplementedException(); }
static int InputYearIn() { throw new NotImplementedException(); }

