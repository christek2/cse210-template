using System;

public class Checklist : Goal
{
    private int _timesToRepeat;
    private int _bonusPoints;

    public Checklist()
    {}

    public override void RecordEvent()
    {}
    public override void IsComplete() // type to bool
    {}
    public override void Execute(string fileName)
    {}
    public void SetRepetitions(int repetitions)
    {}
}