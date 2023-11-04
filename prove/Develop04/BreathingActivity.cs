public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        //sets base class attributes
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on breathing as the instructions tell you to.";
    }

    public void RunActivity()
    {
        DisplayStartMessage();
        SetTime();
        StartPause();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);

        //guide the user's breathing while the current time does not exceed the endTime
        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in...");
            Countdown(4);

            Console.Write("\nNow breathe out...");
            Countdown(6);

            Console.WriteLine("");
        }

        EndPause();
        DisplayEndMessage();
    }
}