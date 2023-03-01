using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        int completedTime = 0;
        string activity = "";
        
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
                activity = "Breathing";
                Activity act = new Activity($"Welcome to the {activity} activity. \n\nRelax, and follow the instructions.", $"Well done! \n\nYou have completed {completedTime} seconds of the {activity} activity.");
                act.ExecuteBreathe();
            }
            else if (userNum == 2)
            {
                activity = "Reflecting";
                Activity act = new Activity($"Welcome to the {activity} activity. \n\nRelax, and follow the instructions.", $"Well done! \n\nYou have completed {completedTime} seconds of the {activity} activity.");                
                act.ExecuteReflection();
                
            }
            else if (userNum == 3)
            {
                activity = "Listing";
                Activity act = new Activity($"Welcome to the {activity} activity. \n\nRelax, and follow the instructions.", $"Well done! \n\nYou have completed {completedTime} seconds of the {activity} activity.");                
                act.ExecuteListing();
            }
        }
    }
}