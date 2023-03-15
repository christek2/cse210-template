using System;

internal class Program
{
    static void Main(string[] args)
    {
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
                    menu.AddToList(menu.ShowMenu2());
                    break;
                case "2":
                    menu.DisplayGoals();
                    break;
                case "3":
                    menu.SaveFile(menu.GetList());
                    break;
                case "4":
                    menu.LoadFile();
                    break;
                case "5":
                    break;
                case "6":
                    break;
            }
        }    
    }
}