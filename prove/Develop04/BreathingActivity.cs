public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
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

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in...");
            Countdown(4);
            // for (int i = 4; i > 0; i--)
            // {
            //     Console.Write(i);
            //     Thread.Sleep(1000);
            //     Console.Write("\b \b");
            // }

            Console.Write("\nNow breathe out...");
            Countdown(6);
            // for (int i = 6; i > 0; i--)
            // {
            //     Console.Write(i);
            //     Thread.Sleep(1000);
            //     Console.Write("\b \b");
            // }

            Console.WriteLine("");
        }

        EndPause();
        DisplayEndMessage();
    }
}