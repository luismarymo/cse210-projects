using System;

class Program
{
    static void Main(string[] args)
    {   
        //welcome message
        Console.WriteLine("Welcome to the Scripture Memorizer program!");

        //create randomizer instance and get scripture
        ScriptureRandomizer scriptureRandomizer = new ScriptureRandomizer();
        scriptureRandomizer.ChooseScripture();

        //build the reference
        Reference reference = new Reference(scriptureRandomizer.GetChapter(), scriptureRandomizer.GetStartVerse(), scriptureRandomizer.GetEndVerse());

        //pass the reference and scripture into a new scripture object
        Scripture scripture = new Scripture(reference, scriptureRandomizer.GetScripture());

        //display the full scripture before starting loop
        scripture.SplitScripture();
        scripture.DisplayText();
        Console.WriteLine("\n\nPress enter to start, or type 'quit' and run again to get a different scripture:");

        string input = "";
        while (input.ToLower() != "quit")
        {   
            input = Console.ReadLine();

            if (input != "quit")
            {
                //clear the console
                Console.Clear();

                //hide words and display the scripture
                scripture.HideWords();
                scripture.DisplayText();

                Console.WriteLine("\n\nPress enter to continue or type 'quit' to finish:");
            }

            //check if the scripture is fully hidden. if it is, ensure loop ends before next iteration
            if(scripture.IsFullyHidden())
            {
                input = "quit";
            }
        }
    }
}

//EXCEEDING REQUIREMENTS
//To exceed requirements, aside from making it so that the words hidden are random yet not repeated, I had the program choose a random scripture from a list instead of having only one option through the ScriptureRandomizer class. I would have preferred not to have that many getter methods as a way to get the information about the scripture, but I really only needed it to return values.

//CODING HELP
//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/how-to-determine-whether-a-string-represents-a-numeric-value --> checking if the characters in a string are numeric
//https://www.tutorialspoint.com/how-to-return-a-string-repeated-n-number-of-times-in-chash#:~:text=Use%20string.,builder%20%3D%20new%20StringBuilder(stringToRepeat. --> how to build a string made of a character repeated a certain admount of times
//https://www.tutorialspoint.com/How-to-calculate-the-length-of-the-string-using-Chash#:~:text=Use%20the%20String.,the%20length%20of%20the%20string. --> getting the lenght of a string