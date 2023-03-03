using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        TimeTracker track = new TimeTracker();
        int completedTime = 0;
        string activity = "";
        string description = "";
        
        int userNum = 0;
        while (userNum < 4)
        {
            Console.Clear();
            track.DisplayTime();
            Console.WriteLine();
            menu.DisplayOptions();
            Console.Write("Enter the number for the action you would like to complete: ");
            string _userInput = Console.ReadLine();
            userNum = int.Parse(_userInput);

            userNum = int.Parse(_userInput);
            if (userNum == 1)
            {
                activity = "Breathing";
                description = "Focus on your breathing";
                Activity act = new Activity($"Welcome to the {activity} activity. \n{description}. \n\nRelax, and follow the instructions.", $"Well done! \n\nYou have completed {completedTime} seconds of the {activity} activity.");
                track.AddTime(act.ExecuteBreathe());
            }
            else if (userNum == 2)
            {
                activity = "Reflecting";
                description = "Take time to reflect on your life";
                Activity act = new Activity($"Welcome to the {activity} activity. \n{description}. \n\nRelax, and follow the instructions.", $"Well done! \n\nYou have completed {completedTime} seconds of the {activity} activity.");                
                track.AddTime(act.ExecuteReflection());
            }
            else if (userNum == 3)
            {
                activity = "Listing";
                description = "Prepare to list as many things as you can according to the following prompt";
                Activity act = new Activity($"Welcome to the {activity} activity. \n{description}. \n\nRelax, and follow the instructions.", $"Well done! \n\nYou have completed {completedTime} seconds of the {activity} activity.");                
                track.AddTime(act.ExecuteListing());
            }
        }
    }
}