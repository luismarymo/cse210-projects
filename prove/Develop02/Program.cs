using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        //start the program with a welcome message and a Journal instance
        Console.WriteLine("Welcome to the Journal Program!");
        Journal journal = new Journal();

        string option = "";
        while (option != "6")
        {
            //display the menu and ask for user input
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Count emotions");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Save");
            Console.WriteLine("6. Quit");

            Console.Write("What would you like to do? ");
            option = Console.ReadLine();

            if (option == "1")
            {
                journal.NewEntry();
            }

            else if (option == "2")
            {
                journal.Display();
            }

            else if (option == "3")
            {
               journal.EmotionCounter();
            }

            else if (option == "4")
            {
                journal.Load(journal.GetFilename());
            }

            else if (option == "5")
            {
                journal.Save(journal.GetFilename());
            }

            else if (option == "6")
            {   
                //opt out of the loop
                continue;
            }

            //in the case that the user types in something that is not one of the options
            else 
            {
                Console.WriteLine("Invalid option.");
            }
        }
    }
}

//EXCEEDING REQUIREMENTS
//To exceed requirements, I added more information to be saved to an entry with the _emotion member variable,
//that allows the user to record how they were feeling in the moment they created the entry,
//and can also be evaluated and displayed to the user as a counter with the journal method EmotionCounter()

//CODING HELP
//https://www.geeksforgeeks.org/c-sharp-tolower-method/ --> how to convert string characters into lowercase