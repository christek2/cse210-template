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
        _options.Add("3. Back");
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
                break;
            case > 3 or < 1:
                Console.WriteLine("Seletion not available; please enter an option from the list above. ");
                ShowAnimation();
                DisplayManageOptions();
                break;
        }
    }
    public string DisplayInterface()
    {
        // using (StreamWriter file = new StreamWriter(_fileName))
        // {}
        Console.Clear();

        string[] assets = System.IO.File.ReadAllLines(_fileName);
        if (assets.Count() != 0)
        {
            Console.WriteLine("Asset Name:              Dep This Year:           Retirement:              Type:                    Description:");
            Console.WriteLine();
            foreach (string asset in assets)
            {
                string[] parts = asset.Split("; ");
                double depr = 0;
                if (parts[0] == "StraightLine")
                {
                    SLine straight = new SLine();
                    depr = straight.CalcDepr(0, double.Parse(parts[6]), double.Parse(parts[4]) - double.Parse(parts[5]), 0);
                }
                else if (parts[0] == "DoubleDeclining")
                {
                    double rate = 2 / double.Parse(parts[6]);
                    DDec doub = new DDec();
                    depr = doub.CalcDepr(rate, double.Parse(parts[6]), double.Parse(parts[4]) - double.Parse(parts[5]), double.Parse(parts[4]), 87/360);
                }
                else if (parts[0] == "UnitsOfProduction")
                {
                    UOfProd prod = new UOfProd();
                    depr = prod.CalcDepr(0, double.Parse(parts[6]), double.Parse(parts[4]) - double.Parse(parts[5]), 0);
                }
                SLine test = new SLine();
                string date = test.GenerateRetDate(parts[3], double.Parse(parts[6]));
                string space1 = test.InsertSpace(parts[1], 25);
                string line = $"{parts[1]}{space1}{depr}";
                string space2 = test.InsertSpace(line, 50);
                string line2 = $"{line}{space2}{date}";
                string space3 = test.InsertSpace(line2, 75);
                string line3 = $"{line2}{space3}{parts[0]}";
                string space4 = test.InsertSpace(line3, 100);
                Console.WriteLine($"{line3}{space4}{parts[2]}");
            }
        }
        else
        {
            Console.WriteLine("There are no assets saved.");
        }
        Console.WriteLine();
        Console.WriteLine();
        SLine coiso = new SLine();
        coiso.InsertSpace("Thing", 10);
        Console.Write("Enter 'M' to Manage Assets (press enter to exit) ");
        string userInput = Console.ReadLine();
        
        if (userInput == "M" || userInput == "m")
        {
            DisplayManageOptions();
        }
        return userInput;
    }
    public void ShowAnimation()
    {
        // Thread.Sleep(3000);
        for (int i = 4; i > 0; i--)
        {
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b\b");
            Console.Write(">");
            Thread.Sleep(250);
            Console.Write("\b\b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b\b");
            Console.Write("<");
            Thread.Sleep(250);
            Console.Write("\b\b");
        }
    }
}