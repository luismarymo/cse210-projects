using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        bool running = true;

        List<int> numbers = new List<int>();
        do
        {
            Console.Write("Enter number: ");
            string userEntry = Console.ReadLine();
            int userNumber = int.Parse(userEntry);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
            else
            {
                running = false;
            }
        } while (running == true);

        int sum = numbers.Sum();
        float avg = ((float)sum) / numbers.Count;
        int max = numbers.Max();

        int smallestPos = 1000000000;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPos)
            {
                smallestPos = number;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {smallestPos}");
        Console.WriteLine("The sorted list is:");

        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}