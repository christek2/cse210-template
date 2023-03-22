using System;

public class Depr : Menu
{
    private int _usefulLife;
    private int _initialCost;
    private int _salvageValue;
    private string _assetName;
    private string _assetDescription;
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
    public int GetInitialCost()
    {
        return _initialCost;
    }
    public void SetInititalCost(int cost)
    {
        _initialCost = cost;
    }
    public int GetSalvage()
    {
        return _salvageValue;
    }
    public void SetSalvage(int salvage)
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