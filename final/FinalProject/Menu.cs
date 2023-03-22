using System;
using System.IO;

public class Menu
{
    private List<string> _options = new List<string>();
    private string _fileName;
    private List<string> _possessedAssets = new List<string>();

    public Menu()
    {
        _fileName = "AssetSheet.txt";
        _options.Add("1. Add Asset");
        _options.Add("2. Remove Asset");
        _options.Add("3. Edit Existing Asset's Information");
        _options.Add("4. Back");
    }

    public void DisplayManageOptions()
    {
        Console.Clear();
        Manage mng = new Manage();

        foreach (string option in _options)
        {
            Console.WriteLine(option);
        }
        Console.WriteLine();
        Console.Write("Enter an option from the list: ");
        int userInput = int.Parse(Console.ReadLine());

        switch (userInput)
        {
            case 1:
                mng.AddAssets();
                break;
            case 2:
                mng.RemoveAssets();
                break;
            case 3:
                mng.EditAssets();
                break;
            case 4:
                // ShowAnimation();
                break;
            case 5:
                Console.WriteLine("Seletion not available; please enter an option from the list above. ");
                ShowAnimation();
                DisplayManageOptions();
                break;
        }
        DisplayInterface();
    }
    public string DisplayInterface()
    {
        // using (StreamWriter file = new StreamWriter(_fileName))
        // {}
        Console.Clear();

        string[] assets = System.IO.File.ReadAllLines(_fileName);
        if (assets.Count() != 0)
        {
            Console.WriteLine("Depreciable Assets: ");
            Console.WriteLine();
            foreach (string asset in assets)
            {
                Console.WriteLine(asset);
            }
        }
        else
        {
            Console.WriteLine("There are no assets saved.");
        }
        Console.WriteLine();
        Console.Write("Enter 'M' to Manage Assets ");
        string userInput = Console.ReadLine();
        
        if (userInput == "M" || userInput == "m")
        {
            DisplayManageOptions();
        }
        return userInput;
    }
    public void ShowAnimation()
    {
        Thread.Sleep(3000);
    }
}