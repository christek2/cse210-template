using System;
using System.IO;

public class Simple : Goal
{
    public Simple()
    {
        SetType("Simple Goal");
    }

    public override string Execute()
    {
        return GetInfo();
    }
    public override void RecordEvent()
    {
        
    }
}