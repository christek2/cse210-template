using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Activity act = new Activity();
        int userNum = 0;
        while (userNum < 4)
        {
            menu.DisplayOptions();
            Console.Write("Enter the number for the action you would like to complete: ");
            string _userInput = Console.ReadLine();
            userNum = int.Parse(_userInput);

            userNum = int.Parse(_userInput);
            if (userNum == 1)
            {
                act.ExecuteBreathe();
            }
            else if (userNum == 2)
            {
                act.ExecuteReflection();
            }
            else if (userNum == 3)
            {
                act.ExecuteListing();
            }
        }
    }
}