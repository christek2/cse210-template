using System;

internal class Program
{
    static void Main(string[] args)
    {
        PointTracker track = new PointTracker();
        Menu menu = new Menu();

        string userChoice = "0";
        while (userChoice != "6")
        {
            menu.ShowMenu1();
            Console.Write("Enter the number for the action you would like to complete: ");
            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    track.AddToList(menu.ShowMenu2());
                    break;
                case "2":
                    foreach (string goal in track.GetList())
                    {
                        Console.WriteLine(goal);
                    }
                    Console.WriteLine();
                    Console.Write("--Press enter to continue--");
                    Console.ReadLine();
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
            }
        }    
    }
}