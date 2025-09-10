Console.Clear();
Console.Title = "Trip Planner!";

Console.Write("Welcome to Jaden's Trip Planner! Press any key to get started!"); //introduction to trip planner, use Write with a space in the string to match example
Console.ReadKey(true);

Console.Clear();
Console.WriteLine("Driver"); //name of person driving
string driverName = Console.ReadLine()!;
Console.Clear();

Console.WriteLine("destination"); //ask for destination
string destinationName = Console.ReadLine()!;
Console.Clear();

double dubDistanceMi = 0; // Have to set the type before the block so we can use it later!

while (dubDistanceMi <= 0) // Loop to make sure we get a useable number for later
{
    Console.WriteLine("miles to destination?");
    string stringDistanceMi = Console.ReadLine()!;
    //setting type for later use
    bool stringParsed;
    if (double.TryParse(stringDistanceMi, out dubDistanceMi)) //Did we parse the string?
    //we did parse the string
    {
        if (dubDistanceMi > 0) //Is the distance a valid number?
        //it is a valid number
        {
            stringParsed = true;
        }
        //it is not a valid number
        else stringParsed = false;
    }
    //we didn't parse the string
    else stringParsed = false;

    //Now check if the string was parsed, if it was, while loop continues and exits
    if (stringParsed == true) continue;
    //If it wasn't, clear and add a message explaining it didn't and reset loop
    else
    {
        Console.Clear();
        Console.WriteLine("I'm sorry but that response won't work, can you please try again?");
    }
}

Console.Clear();
Console.WriteLine("What will your average speed be? (mph)"); //ask for average speed
string stringAvgSpeed = Console.ReadLine()!;

Console.Clear();
Console.WriteLine("What kind of gas mileage does your ride get? (mi/g)");
string stringMPG = Console.ReadLine()!;

Console.Clear();
Console.WriteLine("How many passengers will you be taking? Not including the driver, of course!");
string stringPassengers = Console.ReadLine()!;

Console.Clear();
Console.WriteLine("What currency do you prefer to use? ($, £, ¥, €)");
string stringCurrency = Console.ReadLine()!;

Console.Clear();
Console.WriteLine("What's the current price of a gallon of fuel? ($/gal)"); //fuel price per gallon in dollars
string stringFuelPrice = Console.ReadLine()!;

/*
Average song length and songs needed for the playlist
could be cool to have a "this is how many times you could listen to this"

Console.WriteLine("placeholder");
Console.WriteLine("placeholder");
Console.WriteLine("placeholder");
*/