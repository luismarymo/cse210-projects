using System;

class Program
{
    static void Main(string[] args)
    {   
        string option = "";
        while(option != "4")
        {   
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
                continue;
            }

            else
            {
                Console.WriteLine("\nInvalid choice.");
            }
        }
    }
}