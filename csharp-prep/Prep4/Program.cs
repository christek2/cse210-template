using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        bool repeat = true;
        while (repeat == true)
        {
            Console.Write("Enter an integer to be added to the list (enter '0' when done): ");
            string userNum = Console.ReadLine();
            int userAns = int.Parse(userNum);

            if (userAns == 0)
            {
                Console.WriteLine("List finished.");
                repeat = false;
            }
            else
            {
                numbers.Add(userAns);
            }
        }

        Console.WriteLine("Here's the list:");
        Console.WriteLine("");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine("");

        int sum = numbers.Sum();
        int avg = (sum) / (numbers.Count());
        int max = numbers.Max();

        Console.WriteLine("");
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {avg}");
        Console.WriteLine($"Maximum: {max}");
        Console.WriteLine("");
    }
}