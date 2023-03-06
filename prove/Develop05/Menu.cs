using System;

public class Menu
{
    private List<string> _options = new List<string>();

    public Menu()
    {
        _options.Add("1.");
        _options.Add("2.");
        _options.Add("3.");
        _options.Add("4.");
        _options.Add("5.");
    }

    public int DisplayOptions()
    {
        foreach (string opt in _options)
        {
            Console.WriteLine("opt");
        }
        Console.Write("Enter the number for the action you would like to select: ");
        int userInput = Console.Read();

        return userInput;
    }
}