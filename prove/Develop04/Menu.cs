using System;

public class Menu
{
    private List<string> _options = new List<string>();

    public Menu()
    {
        _options.Add("1. Breathing Activity");
        _options.Add("2. Reflection Activity");
        _options.Add("3. List Activity");
        _options.Add("4. Quit");
    }

    public void DisplayOptions()
    {
        foreach (string i in _options)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();
    }
}