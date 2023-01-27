using System;

public class Menu
{
    public List<string> _menuOptions = new List<string>(){"Write New Entry", "Display Entries", "Load File", "Quit Journal"};
    public string userChoice = "";

    public string AcceptUserInput()
    {
        Console.WriteLine("Choose the number of the action that you would like to perform: ");
        Console.Write("> ");
        string userInput = Console.ReadLine();
        return userInput;
    }
    public void ChooseMenuOption(string input)
    {
        if (input == "1")
        {
            Entry entry1 = new Entry();
            entry1.WriteNew(entry1.GetDate(), entry1.GetPrompt());
        }
        else if (input == "2")
        {}
        else if (input == "3")
        {}
        else if (input == "4")
        {}
        else 
        {}
    }
}