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
    int stringParsed;
    if (double.TryParse(stringDistanceMi, out dubDistanceMi)) //Did we parse the string?
    //we did parse the string
    {
        if (dubDistanceMi > 0) //Is the distance a valid number?
        //it is a valid number
        {
            stringParsed = 1;
        }
        //it is not a valid number
        else stringParsed = 0;
    }
    //we didn't parse the string
    else stringParsed = 0;

    //Now check if the string was parsed, if it was, while loop continues and exits
    if (stringParsed == 1) continue;
    //If it wasn't, clear and add a message explaining it didn't and reset loop
    else
    {
        Console.Clear();
        Console.WriteLine("I'm sorry but that response won't work, can you please try again?");
    }
}

//Console.Clear();
Console.Write(dubDistanceMi);

/*
if (double.TryParse(stringDistanceMi, out double dubDistanceMi)) ;
else
{
    Console.WriteLine("I'm sorry but we couldn't figure out what you meant!");
    Environment.Exit(1);
}
*/
/*
Console.WriteLine("placeholder"); //ask for average speed

Console.WriteLine("placeholder"); //ask for gas mileage

Console.WriteLine("placeholder"); //how many riders not including driver

Console.WriteLine("placeholder"); //what currency we're going to use

Console.WriteLine("placeholder"); //fuel price per gallon in dollars
*/
/*
Average song length and songs needed for the playlist
could be cool to have a "this is how many times you could listen to this"

Console.WriteLine("placeholder");
Console.WriteLine("placeholder");
Console.WriteLine("placeholder");
*/