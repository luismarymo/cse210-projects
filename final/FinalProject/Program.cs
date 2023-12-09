using System;

class Program
{
    static void Main(string[] args)
    {
        //welcome message
        Console.WriteLine("Welcome to the Cat Collector Game!");
        Console.WriteLine("The purpose of this game is to collect as many cats as you can, which you can only do if you meet their specific requirements. By adopting cats, or going to the different locations and adding items to your inventory, you can level up!\n");

        //prompt the user for their name
        Console.Write("Before we start, enter your name: ");
        string name = Console.ReadLine();

        Console.WriteLine("");

        //create the player object and pass it into a game instance then run the game
        Player player = new Player(name);

        Console.WriteLine($"Have fun, {name}!\n");

        Game game = new Game(player);
        game.Run();

        //goodbye message
        Console.WriteLine("Thank you for playing!");
    }
}

//CODE HELP
//https://www.codecademy.com/resources/docs/c-sharp/strings/contains --> C# .Contains()
//https://stackoverflow.com/questions/20430405/percentage-based-probability --> Percentage based probability
//https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1 --> Formating the current time