using System;

public class UOfProd : Depr
{
    private int _productionLimit;

    public UOfProd()
    {}

    public double GetProdLimit()
    {
        return _productionLimit;
    }
    public void SetProdLimit(int limit)
    {
        _productionLimit = limit;
    }
    public override double CalcDepr(double rate, double usefulLife, double depreciableCost, double curBV, double portionOfYear=1)
    {
        return Math.Round((depreciableCost / usefulLife) * portionOfYear, 2);
    }
}