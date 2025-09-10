
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
double dubAvgSpeed = 0; // Have to set the type before the block so we can use it later!
while (dubAvgSpeed <= 0) // Loop to make sure we get a useable number for later
{
    Console.WriteLine("What will your average speed be? (mph)");
    string stringAvgSpeed = Console.ReadLine()!;
    //setting type for later use
    bool stringParsed;
    if (double.TryParse(stringAvgSpeed, out double parseOut) && parseOut > 0) //Did we parse the string and is it above 0?
    //we did parse the string
    stringParsed = true;
    //we didn't parse the string
    else stringParsed = false;

    //Now check if the string was parsed, if it was, while loop continues and exits
    if (stringParsed == true) dubAvgSpeed = parseOut;
    //If it wasn't, clear and add a message explaining it didn't and reset loop
    else
    {
        Console.Clear();
        Console.WriteLine(stringError);
    }
}

Console.Clear();
double dubMPG = 0; // Have to set the type before the block so we can use it later!
while (dubMPG <= 0) // Loop to make sure we get a useable number for later
{
    Console.WriteLine("What kind of gas mileage does your ride get? (mi/g)");
    string stringMPG = Console.ReadLine()!;
    //setting type for later use
    bool stringParsed;
    if (double.TryParse(stringMPG, out double parseOut) && parseOut > 0) //Did we parse the string and is it above 0?
    //we did parse the string
    stringParsed = true;
    //we didn't parse the string
    else stringParsed = false;

    //Now check if the string was parsed, if it was, while loop continues and exits
    if (stringParsed == true) dubMPG = parseOut;
    //If it wasn't, clear and add a message explaining it didn't and reset loop
    else
    {
        Console.Clear();
        Console.WriteLine(stringError);
    }
}

Console.Clear();
int intPassengers = -1; // Have to set the type before the block so we can use it later!
while (intPassengers < 0) // Loop to make sure we get a useable number for later
{
    Console.WriteLine("How many passengers will you be taking? Not including the driver, of course!");
    string stringPassengers = Console.ReadLine()!;
    //setting type for later use
    bool stringParsed;
    if (Int32.TryParse(stringPassengers, out int parseOut) && parseOut >= 0) //Did we parse the string and is it at least 0?
    //we did parse the string
    stringParsed = true;
    //we didn't parse the string
    else stringParsed = false;

    //Now check if the string was parsed, if it was, while loop continues and exits
    if (stringParsed == true) intPassengers = parseOut;
    //If it wasn't, clear and add a message explaining it didn't and reset loop
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

/*
Console.Clear();
Console.WriteLine("What's the current price of a gallon of fuel? ($/gal)"); //fuel price per gallon in dollars
string stringFuelPrice = Console.ReadLine()!;
*/
/*
Average song length and songs needed for the playlist
could be cool to have a "this is how many times you could listen to this"

Console.WriteLine("placeholder");
Console.WriteLine("placeholder");
Console.WriteLine("placeholder");
*/