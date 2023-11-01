using System.Diagnostics;
using Microsoft.VisualBasic;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _time;

    private List<string> _animationSymbols = new List<string>()
    {
        "|", "/", "-", "\\", "|", "/", "-", "\\"
    };

    protected Stopwatch sw = new Stopwatch();
    private double lastFrame;

    protected double deltaTime()
    {
        TimeSpan timeSpan = this.sw.Elapsed;
        double firstFrame = timeSpan.TotalMilliseconds;

        double deltaTime = firstFrame - lastFrame;

        this.lastFrame = timeSpan.TotalMilliseconds;

        return deltaTime;
    }

    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine($"{_description}\n");
    }

    public void SetTime()
    {
        while (true)
        {
            try
            {
                Console.Write("How long, in seconds, would you like for your session? ");
                _time = int.Parse(Console.ReadLine());
                Console.Clear();
                break;
            }

            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number.\n");
            }
        }
    }

    protected void AnimatedPause(int seconds)
    {
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
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }    

    public void StartPause()
    {
        Console.WriteLine("Get ready...");
        AnimatedPause(6);        
    }

    public void EndPause()
    {
        //pausing
        Console.WriteLine("\nWell done!");
        AnimatedPause(4);
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine($"You have completed another {_time} seconds of the {_name} Activity.");
        AnimatedPause(6);
        Console.Clear();
    }
}