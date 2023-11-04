using System;

class Program
{
    static void Main(string[] args)
    {   
        string option = "";
        while(option != "4")
        {   
            //display options
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");

            Console.Write("Select a choice from the menu: ");
            option = Console.ReadLine();

            if (option == "1")
            {   
                BreathingActivity activity = new BreathingActivity();
                activity.RunActivity();
            }

            else if (option == "2")
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.RunActivity();
            }

            else if (option == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.RunActivity();
            }

            else if (option == "4")
            {   
                //loop out
                continue;
            }

            else
            {   
                Console.WriteLine("\nInvalid choice.");
            }
        }
    }
}

//EXCEEDING REQUIREMENTS
//To exceed requirements, I used a try-catch statement on SetTime() Activity method, so that when the user was prompted for a number in seconds, if they didn't enter one, they would be prompted again until they entered a valid input.

//CODING HELP
//Class announcements
//https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/exception-handling-statements#the-try-statement --> handling exceptions in c#