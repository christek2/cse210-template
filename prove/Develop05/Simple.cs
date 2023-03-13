using System;
using System.IO;

public class Simple : Goal
{
    public Simple()
    {
        SetType("Simple Goal");
    }

    public override void Execute()
    {
        GetInfo();
    }
    public override void SaveFile()
    {}
    public override void RecordEvent()
    {}
}