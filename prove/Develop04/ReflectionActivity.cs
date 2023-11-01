public class ReflectionActivity : Activity
{
    private Randomizer randomizer = new Randomizer();

    private List<string> _prompts = new List<string>()
    {
        "stood up for someone else",
        "did something really difficult",
        "helped someone in need",
        "did something truly selfless"
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    public ReflectionActivity()
    {
        _name = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void RunActivity()
    {
        DisplayStartMessage();
        SetTime();
        StartPause();

        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        Countdown(5);

        // for (int i = 5; i > 0; i--)
        // {
        //     Console.Write(i);
        //     Thread.Sleep(1000);
        //     Console.Write("\b \b");
        // }

        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);

        while (DateTime.Now < endTime) // FIX TIME. IT PROBABLY GOES OVER
        {
            DisplayQuestion();
        }

        EndPause();
        DisplayEndMessage();
    }

    // private string GetPrompt()
    // {
    //     int i = random.Next(_prompts.Count);
    //     return _prompts[i];
    // }

    // private string GetQuestion()
    // {
    //     int i = random.Next(_questions.Count);
    //     return _questions[i];
    // }

    private void DisplayPrompt()
    {
        //format
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($" --- Think of a time when you {randomizer.GetRandom(_prompts)}. ---\n");
    }

    private void DisplayQuestion()
    {
        //formatted string with thingy. this would be called as many times as there is time in the main method.
        Console.Write($"> {randomizer.GetRandom(_questions)} ");
        AnimatedPause(10);
    }
}