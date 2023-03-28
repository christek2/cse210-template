using System;
using System.IO;

public class Manage : Depr
{
    private int _positionInTxt;
    private string _fileName;

    public Manage()
    {
        _fileName = "AssetSheet.txt";
    }

    public override double CalcDepr(double rate, double usefulLife, double depreciableCost, double curBV, double portionOfYear=1)
    {
        return 0;
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
        Console.Write("What is the expected salvage value of the asset (exclude symbols and commas)? ");
        double salvage = double.Parse(Console.ReadLine());
        Console.Write("What is the useful life of this asset? ");
        double usefulLife = double.Parse(Console.ReadLine());
        double unitsPerYear = 0;
        double totalUnits = 0;
        if (deprMethod == 3)
        {
            Console.Write("How many units will be produced every year? ");
            unitsPerYear = double.Parse(Console.ReadLine());
            Console.Write("How many units will be produced in total? ");
            totalUnits = double.Parse(Console.ReadLine());
        }

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
        SetUsefulLife(usefulLife);

        Console.WriteLine();
        Console.Write("Is this information correct (yes/no)? ");
        string userInput = Console.ReadLine();

        if (userInput == "yes")
        {

            string newAsset = $"{method}; {name}; {desc}; {date}; {cost}; {salvage}; {usefulLife}";
            PrintToSheet(_fileName, newAsset);
            Console.WriteLine($"Saving ");
            ShowAnimation();
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
    {
        Console.Clear();

        string[] assets = System.IO.File.ReadAllLines(_fileName);
        int index = 1;
        foreach (string i in assets)
        {
            string[] parts = i.Split("; ");
            Console.WriteLine($"{index}. {parts[1]}");
            index = index + 1;
        }
        Console.WriteLine($"{index}. Back");
        Console.WriteLine();
        Console.Write("Enter the number of the asset you would like to delete: ");
        int userInput = int.Parse(Console.ReadLine());

        if (userInput != index)
        {
            Console.Clear();
            Console.WriteLine(assets[userInput - 1]);
            Console.WriteLine();
            Console.Write("Is this the item you would like to delete (yes/no)? ");
            string userInput2 = Console.ReadLine();

            if (userInput2 == "yes")
            {
                List<string> revisedAssets = new List<string>();
                foreach (string i in assets)
                {
                    revisedAssets.Add(i);
                }
                revisedAssets.RemoveAt(userInput - 1);
                using (StreamWriter file = new StreamWriter(_fileName))
                {
                    foreach (string i in revisedAssets)
                    {
                        file.WriteLine(i);
                    }
                }
                Console.WriteLine("Removing ");
                ShowAnimation();
            }
            else if (userInput2 == "no")
            {
                RemoveAssets();
            }
            else
            {
                DisplayManageOptions();
            }
        }
    }
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
    public void SetFileName(string fileName)
    {
        _fileName = fileName;
    }
    public void PrintToSheet(string fileName, string newAsset)
    {
        List<string> savedAssets = new List<string>();
        string[] assets = System.IO.File.ReadAllLines(fileName);
        int newLineIndex = assets.Count();

        foreach (string asset in assets)
        {
            savedAssets.Add(asset);
        }

        savedAssets.Insert(newLineIndex, newAsset);

        using (StreamWriter file = new StreamWriter(fileName))
        {
            foreach (string line in savedAssets)
            {
                file.WriteLine(line);
            }
        }
    }
}