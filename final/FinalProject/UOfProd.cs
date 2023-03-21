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
    public override void CalcDepr()
    {}
}