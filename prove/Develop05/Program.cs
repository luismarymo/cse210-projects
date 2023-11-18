using System;

class Program
{
    static void Main(string[] args)
    {
        //start program with an instance of the GoalsViewer class
        GoalsViewer goalsViewer = new GoalsViewer();

        //display menu options
        goalsViewer.Menu();
    }
}

//EXCEEDING REQUIREMENTS
//To exceed requirements, I made the score always stand out more by changing the color of the text printed out on the terminal whenever the score was going to be displayed, and also when the user earned new points.

//CODING HELP
//https://code-maze.com/csharp-convert-string-to-bool/ --> converting a string to bool
//https://www.geeksforgeeks.org/c-sharp-how-to-change-foreground-color-of-text-in-console/ --> change the foreground color in the terminal
//https://learn.microsoft.com/en-us/dotnet/api/system.console.resetcolor?view=net-7.0 --> reset colors of the terminal