using System;

class Program
{
    static void Main(string[] args)
    {
        //welcome message

        //prompt the user for a name
        
        string name = "John Doe";

        Player player = new Player(name);

        //create the game instance and run it
        Game game = new Game(player);
        game.Run();
    }
}

//CODE HELP
//https://www.codecademy.com/resources/docs/c-sharp/strings/contains --> C# .Contains()