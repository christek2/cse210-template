using System;

class Program
{
    static void Main(string[] args)
    {
        Random randNum = new Random();
        int number = randNum.Next(1, 11);

        bool match = false;
        while (match == false)
        {
            Console.WriteLine("");
            Console.Write("Enter a number between 1 and 10: ");
            string userNum = Console.ReadLine();
            Console.WriteLine("");

            int userNum0 = int.Parse(userNum);

            if (number == userNum0)
            {
                match = true;
                
            }
            else if (number > 10)
            {
                match = false;
                Console.WriteLine("Guess a number netween 1 and 10");
            }
            else if (number > userNum0)
            {
                match = false;
                Console.WriteLine("Sorry, that is not the number. Try guessing higher...");
            }
            else if (number < userNum0)
            {
                match = false;
                Console.WriteLine("Sorry, that is not the number. Try guessing lower...");
            }

            if (match == true)
            {
                Console.WriteLine($"The number was: {userNum0}");
                Console.WriteLine("Congratulations! You Win!");
                Console.WriteLine("");
            }
        }
    }
}