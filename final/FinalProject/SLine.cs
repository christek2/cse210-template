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
    public override void CalcDepr()
    {}
}