using System;

public class Eternal : Goal
{
    public Eternal()
    {
        SetType("Eternal Goal");
    }

    public override string Execute()
    {
        return GetInfo();
    }
    public override void SaveFile()
    {}
    public override void RecordEvent()
    {}
}