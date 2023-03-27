using System;

public class SLine : Depr
{
    private double _slRate;

    public SLine()
    {}

    public double GetSLRate()
    {
        return _slRate;
    }
    public void SetSLRate(double rate)
    {
        _slRate = rate;
    }
    public override double CalcDepr(double rate, double usefulLife, double depreciableCost, double curBV, double portionOfYear=1)
    {
        return Math.Round((depreciableCost / usefulLife) * portionOfYear, 2);
    }
}