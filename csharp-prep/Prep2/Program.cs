using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter grade percentage (%): ");
        string stringPercentage = Console.ReadLine();
        int percentage = int.Parse(stringPercentage);

        string letter = "";
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else if (percentage < 60)
        {
            letter = "F";
        }

        string sign = "";
        if (!(letter == "A" || letter == "F"))
        {
            if (percentage % 10 >= 7)
            {
                sign = "+";
            }
            else if (percentage % 10 < 3)
            {
                sign = "-";
            }
        }

        Console.WriteLine($"Your grade is {letter}{sign}");

        if (percentage >= 70)
        {
            Console.Write("You passed! Congratulations");
        }
        else
        {
            Console.Write("You failed. Don't be afraid to try again!");
        }
    }
}