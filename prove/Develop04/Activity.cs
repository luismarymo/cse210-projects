using System.Diagnostics;
using Microsoft.VisualBasic;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _time;

    //list with symbols for the animations
    private List<string> _animationSymbols = new List<string>()
    {
        "|", "/", "-", "\\", "|", "/", "-", "\\"
    };

    protected Stopwatch sw = new Stopwatch();
    private double _lastFrame;

    protected double DeltaTime()
    {
        TimeSpan timeSpan = this.sw.Elapsed;
        double firstFrame = timeSpan.TotalMilliseconds;

        double deltaTime = firstFrame - _lastFrame;

        this._lastFrame = timeSpan.TotalMilliseconds;

        return deltaTime;
    }

    public void DisplayStartMessage()
    {
        //standard start message for all activities
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine($"{_description}\n");
    }

    public void SetTime()
    {
        //sets _time with user input
        while (true)
        {
            try
            {
                Console.Write("How long, in seconds, would you like for your session? ");
                _time = int.Parse(Console.ReadLine());
                Console.Clear();
                break; //user entered valid input, so the loop can end
            }

            catch (FormatException)
            {
                //user did not enter a number
                Console.WriteLine("Please enter a valid number.\n");
            }
        }
    }

    protected void AnimatedPause(int seconds)
    {
        //shows a spinning animation for the given duration
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string symbol = _animationSymbols[i];

            Console.Write(symbol);
            Thread.Sleep(300);
            Console.Write("\b \b");

            i++;
            if (i >= _animationSymbols.Count)
            {
                i = 0;
            }
        }

        Console.WriteLine("");
    }

    protected void Countdown(int seconds)
    {
        //counts down from the given seconds
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }    

    public void StartPause()
    {   
        //begining pause for all activities
        Console.WriteLine("Get ready...");
        AnimatedPause(6);        
    }

    public void EndPause()
    {
        //ending pause for all activities
        Console.WriteLine("\nWell done!");
        AnimatedPause(4);
    }

    public void DisplayEndMessage()
    {   
        //standard ending message for all activities
        Console.WriteLine($"You have completed another {_time} seconds of the {_name} Activity.");
        AnimatedPause(6);
        Console.Clear();
    }
}