public class ReflectionActivity : Activity
{
    private Randomizer randomizer = new Randomizer();

    //list of prompts
    private List<string> _prompts = new List<string>()
    {
        "stood up for someone else",
        "did something really difficult",
        "helped someone in need",
        "did something truly selfless"
    };

    //list of questions
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
        //sets base class attributes
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

        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);

        //display questions as long as the current time does not exceed the endTime
        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
        }

        EndPause();
        DisplayEndMessage();
    }

    private void DisplayPrompt()
    {
        //displays a random prompt from _prompts
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($" --- Think of a time when you {randomizer.GetRandom(_prompts)}. ---\n");
    }

    private void DisplayQuestion()
    {
        //displays a random question from _questions
        Console.Write($"> {randomizer.GetRandom(_questions)} ");
        AnimatedPause(10);
    }
}