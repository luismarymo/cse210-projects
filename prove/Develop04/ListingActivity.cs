public class ListingActivity : Activity
{
    private Randomizer randomizer = new Randomizer();

    //list of prompts
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    
    //counter for the amount of items listed
    private int _itemsListed = 0;

    public ListingActivity()
    {
        //sets base class attributes
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void RunActivity()
    {
        DisplayStartMessage();
        SetTime();
        StartPause();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        DisplayPrompt();
        Console.Write("You may begin in: ");
        Countdown(5);

        Console.WriteLine("");

        this.sw.Start();

        double accumulator = 0.0;

        //allow the user to input as long as the time accumulated doesnt go over the set _time
        while (accumulator <= (_time * 1000))
        {
            accumulator += this.DeltaTime();

            if (!Console.KeyAvailable)
            {
                continue;
            }
            
            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("");
                _itemsListed++; //add to counter
            }
        }

        //display the amount of items listed
        Console.WriteLine($"You listed {_itemsListed} items!");
    
        EndPause();
        DisplayEndMessage();
    }

    private void DisplayPrompt()
    {
        //displays a random prompt from _prompts
        Console.WriteLine($" --- {randomizer.GetRandom(_prompts)} ---");
    }
}