using System;

public class Menu
{
    public List<string> _menuOptions = new List<string>(){"1. Write New Entry", "2. Display Entries", "3. Save Entry", "4. Load File", "5. Quit Journal"};
    public string _userChoice;
    public bool _showMenu;

    public string AcceptUserInput()
    {
        Console.WriteLine();
        Console.WriteLine("Choose the number of the action that you would like to perform: ");
        foreach (string item in _menuOptions)
        {
            Console.WriteLine(item);
        }
        Console.Write("> ");
        string userInput = Console.ReadLine();
        return userInput;
    }
    public bool UserToMenu(string input)
    {   
        Entry entryData;

        if (input == "1")
        {
            Entry entry1 = new Entry();
            entryData = entry1.WriteNew(entry1.GetDate(), entry1.GetPrompt());
            return true;
        }
        else if (input == "2")
        {
            Journal journal1 = new Journal();
            journal1.DisplayAll();
            return true;
        }
        else if (input == "3")
        {   
            
            Journal journal3 = new Journal();
            journal3.SaveEntry(entryData);
            return true;
        }
        else if (input == "4")
        {
            Journal journal2 = new Journal();
            journal2._fileName = journal2.LoadFile();
            Console.WriteLine($"{journal2._fileName} was loaded");
            return true;
        }
        else if (input == "5")
        {
            Console.WriteLine("You have exited the journal.");
            return false;
        }
        else 
        {
            Console.WriteLine($"Sorry, {input} is not a recognized choice. Please choose one of the numbers from above.");
            return true;
        }
    }
}