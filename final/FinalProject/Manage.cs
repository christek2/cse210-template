using System;

public class Manage : Depr
{
    private int _positionInTxt;
    private string _fileName;

    public Manage()
    {
        _fileName = "AssetSheet.txt";
    }

    public void AddAssets()
    {
        Console.Clear();

        Console.Write("Enter the name of the new asset: ");
        string name = Console.ReadLine();
        Console.Write("Enter the depreciation type of the asset ('1' for straight-line, '2' for double-declining, '3' for units-of-production): ");
        int deprMethod = int.Parse(Console.ReadLine());
        Console.Write("Enter a description of the asset: ");
        string desc = Console.ReadLine();
        Console.Write("What is the date this asset was purchased (--/--/----)? ");
        string date = Console.ReadLine();
        Console.Write("What was the intial cost of the asset (exclude symbols and commas)? ");
        double cost = double.Parse(Console.ReadLine());
        Console.Write("What is the expected salvage value of the asset? ");
        double salvage = double.Parse(Console.ReadLine());

        string method = "";
        switch (deprMethod)
        {
            case 1:
                method = "StraightLine";
                break;
            case 2:
                method = "DoubleDeclining";
                break;
            case 3:
                method = "UnitsOfProduction";
                break;
        }

        SetAssetName(name);
        SetAssetType(method);
        SetAssetDesc(desc);
        SetDateofPurchase(date);
        SetInititalCost(cost);
        SetSalvage(salvage);

        Console.WriteLine();
        Console.Write("Is this information correct (yes/no)? ");
        string userInput = Console.ReadLine();

        if (userInput == "yes")
        {
            Save save = new Save();
            save.SaveToFile(_fileName);
        }
        else if (userInput == "no")
        {
            Console.Write("Would you like to re-enter the information (yes/no)? ");
            string userInput2 = Console.ReadLine();

            if (userInput2 == "yes")
            {
                AddAssets();
            }
            else
            {
                DisplayManageOptions();
            }
        }
        else
        {
            DisplayManageOptions();
        }
    }
    public void RemoveAssets()
    {}
    public void EditAssets()
    {}
    public int GetPosition()
    {
        return _positionInTxt;
    }
    public void SetPosition(int position)
    {
        _positionInTxt = position;
    }
    public string GetFileName()
    {
        return _fileName;
    }
    public void SetProdLimit(string fileName)
    {
        _fileName = fileName;
    }
    public void PrintToSheet()
    {}
}