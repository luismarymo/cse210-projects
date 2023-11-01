public class ListingActivity : Activity
{
    private Randomizer randomizer = new Randomizer();

    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    
    private int _itemsListed = 0;

    public ListingActivity()
    {
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

        while (accumulator <= (_time * 1000))
        {
            accumulator += this.deltaTime();

            if (!Console.KeyAvailable)
            {
                continue;
            }
            
            ConsoleKeyInfo key = Console.ReadKey();
            // Console.WriteLine("");

            if (key.Key == ConsoleKey.Enter)
            {
                // Console.WriteLine("> ");
                Console.WriteLine("");
                _itemsListed++;
            }
        }

        // DateTime startTime = DateTime.Now;
        // DateTime endTime = startTime.AddSeconds(_time);

        // while (DateTime.Now < endTime)
        // {
        //     Console.Write("> ");
        //     Console.ReadLine();

        //     _itemListed++;
        // }

        Console.WriteLine($"You listed {_itemsListed} items! ");
    
        EndPause();
        DisplayEndMessage();
    }

    private void DisplayPrompt()
    {
        //format
        Console.WriteLine($" --- {randomizer.GetRandom(_prompts)} ---");
    }
}