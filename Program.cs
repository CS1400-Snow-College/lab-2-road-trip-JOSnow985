Console.Clear();
Console.Title = "Trip Planner!";

Console.Write("Welcome to Jaden's Trip Planner! Press any key to get started!"); //introduction to trip planner, use Write with a space in the string to match example
Console.ReadKey(true);

Console.Clear();
Console.WriteLine("What's the driver's name?"); //name of person driving
string driverName = Console.ReadLine()!;
Console.Clear();

Console.WriteLine("What's your destination?");
string destinationName = Console.ReadLine()!;

// Using this for the while loops in case we need to change the message
string stringError = "I'm sorry but that response won't work, can you please try again?";

Console.Clear();
double dubDistanceMi = 0; // Have to set the type before the block so we can use it later!
while (dubDistanceMi <= 0) // Loop to make sure we get a useable number for later
{
    Console.WriteLine("How far away, in miles, is your destination?");
    string stringDistanceMi = Console.ReadLine()!;
    //setting type for later use
    bool stringParsed;
    if (double.TryParse(stringDistanceMi, out double parseOut) && parseOut > 0) //Did we parse the string and is it above 0?
    //we did parse the string
    stringParsed = true;
    //we didn't parse the string
    else stringParsed = false;

    //Now check if the string was parsed, if it was, while loop continues and exits
    if (stringParsed == true) dubDistanceMi = parseOut;
    //If it wasn't, clear and add a message explaining it didn't and reset loop
    else
    {
        Console.Clear();
        Console.WriteLine(stringError);
    }
}

Console.Clear();
double dubAvgSpeed = 0; // Maybe add a number that gives a message that you're gonna be going really fast
while (dubAvgSpeed <= 0)
{
    Console.WriteLine("What will your average speed be? (mph)");
    string stringAvgSpeed = Console.ReadLine()!;
    bool stringParsed;
    if (double.TryParse(stringAvgSpeed, out double parseOut) && parseOut > 0) stringParsed = true;
    else stringParsed = false;

    if (stringParsed == true) dubAvgSpeed = parseOut;
    else
    {
        Console.Clear();
        Console.WriteLine(stringError);
    }
}

Console.Clear();
double dubMPG = 0;
while (dubMPG <= 0)
{
    Console.WriteLine("What kind of gas mileage does your ride get? (mi/gal)");
    string stringMPG = Console.ReadLine()!;

    bool stringParsed;
    if (double.TryParse(stringMPG, out double parseOut) && parseOut > 0) stringParsed = true;
    else stringParsed = false;

    if (stringParsed == true) dubMPG = parseOut;
    else
    {
        Console.Clear();
        Console.WriteLine(stringError);
    }
}

Console.Clear();
double dubFuelMax = 0;
while (dubFuelMax <= 0)
{
    Console.WriteLine("How many gallons of fuel does your vehicle hold?");
    string stringFuelMax = Console.ReadLine()!;

    bool stringParsed;
    if (double.TryParse(stringFuelMax, out double parseOut) && parseOut > 0) stringParsed = true;
    else stringParsed = false;

    if (stringParsed == true) dubFuelMax = parseOut;
    else
    {
        Console.Clear();
        Console.WriteLine(stringError);
    }
}

Console.Clear();
int intPassengers = -1; // People can ride alone!
while (intPassengers < 0)
{
    Console.WriteLine("How many passengers will you be taking? Not including the driver, of course!");
    string stringPassengers = Console.ReadLine()!;

    bool stringParsed;
    if (Int32.TryParse(stringPassengers, out int parseOut) && parseOut >= 0) //Did we parse the string and is it at least 0?
    stringParsed = true;
    else stringParsed = false;

    if (stringParsed == true) intPassengers = parseOut;
    else
    {
        Console.Clear();
        Console.WriteLine(stringError);
    }
}

Console.Clear();
if (intPassengers == 0) Console.WriteLine("Riding Solo!");
Console.WriteLine("What currency do you prefer to use? ($, £, ¥, €)");
string stringCurrency = Console.ReadLine()!;

Console.Clear();
double dubDollarPerGallon = 0;
while (dubDollarPerGallon <= 0)
{
    Console.WriteLine("What's the current price of a gallon of fuel? ($/gal)");
    string stringDollarPerGallon = Console.ReadLine()!;

    bool stringParsed;
    if (double.TryParse(stringDollarPerGallon, out double parseOut) && parseOut > 0) stringParsed = true;
    else stringParsed = false;

    if (stringParsed == true) dubDollarPerGallon = parseOut;
    else
    {
        Console.Clear();
        Console.WriteLine(stringError);
    }
}


// Math Time
double totalTimeDriving = dubDistanceMi / dubAvgSpeed;
int hoursDriving = (int)totalTimeDriving; //casting operator to go from double to int
int minutesDriving = (int)Math.Round((totalTimeDriving - hoursDriving) * 60); //Left over time to minutes
if (minutesDriving == 60) //don't want it to say 60 minutes!
{
    hoursDriving += 1;
    minutesDriving = 0;
}

double fuelNeeded = dubDistanceMi / dubMPG * 2;
double tankRange = dubMPG * dubFuelMax;
int fuelStops = (int)Math.Round(fuelNeeded / dubFuelMax);

double fuelCostPay = fuelNeeded * dubDollarPerGallon;

int riders = 1 + intPassengers;

double costPerson = fuelCostPay / riders;
double costMile = fuelCostPay / dubDistanceMi;
double costHour = fuelCostPay / totalTimeDriving;

double songLength = 3.5;
int songsNeeded = (int)Math.Round(totalTimeDriving * 60 / songLength);
// Results Time
Console.Clear();

string driverHeader = "Driver:";
Console.WriteLine($"{driverHeader,-35}{driverName}");

string currencyHeader = "Currency:";
Console.WriteLine($"{currencyHeader,-35}{stringCurrency}");
Console.WriteLine();

string distanceHeader = "Distance (miles):";
Console.WriteLine($"{distanceHeader,-35}{dubDistanceMi:#.##}");

string avgSpeedHeader = "Average Speed (mph):";
Console.WriteLine($"{avgSpeedHeader,-35}{dubAvgSpeed:#.##}");

string timeDrivingHeader = "Time Driving:";
Console.WriteLine($"{timeDrivingHeader,-35}{hoursDriving}H {minutesDriving}M");
Console.WriteLine();

string mpgHeader = "Vehicle Miles per Gallon:";
Console.WriteLine($"{mpgHeader,-35}{dubMPG:#.##}");

string fuelNeededHeader = "Fuel Needed (for a round trip!):";
Console.WriteLine($"{fuelNeededHeader,-35}{fuelNeeded:#.##} gallons");

string tankRangeHeader = "Range per fuel tank:";
Console.WriteLine($"{tankRangeHeader,-35}{tankRange:#.##} miles");

string estFuelStopHeader = "Estimated Fuel Stops:";
Console.WriteLine($"{estFuelStopHeader,-35}{fuelStops}");
Console.WriteLine();

string pricePerGallonHeader = "Gas Price per Gallon:";
Console.WriteLine($"{pricePerGallonHeader,-35}${dubDollarPerGallon:#.##}");

string fuelCostHeader = "Fuel Cost:";
Console.WriteLine($"{fuelCostHeader,-35}${fuelCostPay:#.00}");

string ridersHeader = "Riders (split):";
Console.WriteLine($"{ridersHeader,-35}{riders}");

string costPersonHeader = "Cost per person:";
Console.WriteLine($"{costPersonHeader,-35}${costPerson:#.00}");

string costMileHeader = "Cost per mile:";
Console.WriteLine($"{costMileHeader,-35}${costMile:#0.00}");

string costHourHeader = "Cost per driving hour:";
Console.WriteLine($"{costHourHeader,-35}${costHour:#.00}");
Console.WriteLine();

string songLengthHeader = "Average song length (min):";
Console.WriteLine($"{songLengthHeader,-35}{songLength:#.##}");

string songsNeededHeader = "Suggested Playlist Length:";
Console.WriteLine($"{songsNeededHeader,-35}{songsNeeded} songs");
/*
Average song length and songs needed for the playlist
could be cool to have a "this is how many times you could listen to this"

Console.WriteLine("placeholder");
Console.WriteLine("placeholder");
Console.WriteLine("placeholder");
*/