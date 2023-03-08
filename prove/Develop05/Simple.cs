using System;
using System.IO;

public class Simple : Goal
{
    public Simple()
    {}

    public override void RecordEvent()
    {}
    public override void IsComplete() // type to bool
    {}
    public override void Execute(string fileName)
    {
        Console.Write("What is the name of your goal? ");
        SetName(Console.ReadLine());
        Console.Write("What is the description of this goal? ");
        SetDescription(Console.ReadLine());
        Console.Write("How many points is this goal worth? ");
        string points = Console.ReadLine();
        int newPoints = int.Parse(points);
        Menu menu = new Menu();
        menu.SetPoints(newPoints);
        menu.SetGoal($"Simple Goal - [] {GetName()}: {GetDescription()}; {menu.GetPoints()} points");
        menu.AddGoal(menu.GetGoal());
    }
}