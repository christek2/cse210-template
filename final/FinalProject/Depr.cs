using System;

public abstract class Depr : Menu
{
    private double _usefulLife;
    private double _initialCost;
    private double _salvageValue;
    private string _assetName;
    private string _assetDescription;
    private string _assetDeprType;
    private string _dateOfPurchase;
    private string _estRetDate;

    public Depr()
    {}

    public double GetUsefulLife()
    {
        return _usefulLife;
    }
    public void SetUsefulLife(double life)
    {
        _usefulLife = life;
    }
    public double GetInitialCost()
    {
        return _initialCost;
    }
    public void SetInititalCost(double cost)
    {
        _initialCost = cost;
    }
    public double GetSalvage()
    {
        return _salvageValue;
    }
    public void SetSalvage(double salvage)
    {
        _salvageValue = salvage;
    }
    public string GetAssetName()
    {
        return _assetName;
    }
    public void SetAssetName(string name)
    {
        _assetName = name;
    }
    public string GetAssetType()
    {
        return _assetDeprType;
    }
    public void SetAssetType(string deprType)
    {
        _assetDeprType = deprType;
    }
    public string GetAssetDesc()
    {
        return _assetDescription;
    }
    public void SetAssetDesc(string desc)
    {
        _assetDescription = desc;
    }
    public string GetDateOfPurchase()
    {
        return _dateOfPurchase;
    }
    public void SetDateofPurchase(string date)
    {
        _dateOfPurchase = date;
    }
    public string GetDateOfRetirement()
    {
        return _estRetDate;
    }
    public void SetDateOfRetirment()
    {
        // _estRetDate = 
    }
    public abstract double CalcDepr(double rate, double usefulLife, double depreciableCost, double curBV, double portionOfYear=1);
    public string GenerateRetDate(string dateOfPurchase, double usefulLife)
    {
        string[] parts = dateOfPurchase.Split("/");
        double life = int.Parse(parts[2]) + usefulLife;
        return $"{parts[0]}/{parts[1]}/{life}";
    }
}