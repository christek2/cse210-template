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
    public override void CalcDepr()
    {}
}