using System;

public class DDec : Depr
{
    private double _doubleRate;

    public DDec()
    {}

    public double GetDoubleRate()
    {
        return _doubleRate;
    }
    public void SetDoubleRate(double rate)
    {
        _doubleRate = rate;
    }
    public override double CalcDepr(double rate, double usefulLife, double depreciableCost, double curBV, double portionOfYear=1)
    {
        return Math.Round(curBV * rate * portionOfYear, 2);
    }
}