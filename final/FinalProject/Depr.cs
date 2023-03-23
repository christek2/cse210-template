using System;

public class Depr : Menu
{
    private int _usefulLife;
    private double _initialCost;
    private double _salvageValue;
    private string _assetName;
    private string _assetDescription;
    private string _assetDeprType;
    private string _dateOfPurchase;
    private string _estRetDate;

    public Depr()
    {}

    public int GetUsefulLife()
    {
        return _usefulLife;
    }
    public void SetUsefulLife(int life)
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
    public void GenerateDateOfRetirment()
    {
        // _estRetDate = 
    }
    public virtual void CalcDepr()
    {}
}