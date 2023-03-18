using System;

public class Checklist : Goal
{
    private int _iterations;
    private int _bonus;

    public Checklist()
    {
        SetType("Checklist Goal");
    }

    public override string Execute()
    {
        return GetInfo();
    }
    public override void RecordEvent(string fileName)
    {}
    public override string GetInfo()
    {
        Console.Write("What is the name of your goal? ");
        SetName(Console.ReadLine());
        Console.Write("What is a short description of this goal? ");
        SetDescription(Console.ReadLine());
        Console.Write("What is the amount of points associated with each iteration of this goal? ");
        SetPoints(int.Parse(Console.ReadLine()));
        Console.Write("How many times would you like this goal to repeat? ");
        _iterations = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for completing all of the iterations? ");
        _bonus = int.Parse(Console.ReadLine());

        return GoToString(GoGetType(), GetName(), GetDescription(), GetPoints(), _iterations, _bonus);
    }
    public override string GoToString(string type, string name, string description, int points, int iterations = 0, int bonus = 0)
    {
        return $"[ ] {type}: {name}; {description}; {points}p; {iterations}x; {bonus} (bonus)";
    }
}