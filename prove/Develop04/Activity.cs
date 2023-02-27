using System;

public class Activity
{
    private string _startingMessage;
    private string _endingMessage;
    private int _userTime;
    private string _userPrompt;

    public Activity()
    {}

    public string DisplayStartingMessage()
    {
        return _startingMessage;
    }
    public string DisplayEndingMessage()
    {
        return _endingMessage;
    }
    public void ShowAnimation(int seconds)
    {
        int miliseconds = seconds * 1000;
        int iteration = miliseconds / 4 / 5;
        int repeat = 1;
        while (repeat < 5)
        {
            Console.Write("|");
            Thread.Sleep(iteration);
            Console.Write("\b\b");
            Console.Write("(");
            Thread.Sleep(iteration);
            Console.Write("\b\b");
            Console.Write("|");
            Thread.Sleep(iteration);
            Console.Write("\b\b");
            Console.Write(")");
            Thread.Sleep(iteration);
            Console.Write("\b\b");
            repeat = repeat + 1;
        }
    }
    public int GetUserTime()
    {
        return _userTime;
    }
    public void SetUserTime(int time)
    {
        int timeProportion = time / 60;
        int timeInMils = timeProportion * 1000;
        _userTime = timeInMils;
    }
    public string GetPrompt() 
    {
        return _userPrompt;
    }
    public virtual void SetPrompt(string prompt)
    {
        _userPrompt = prompt;
    }
    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine(prompt);
    }
    public void ExecuteBreathe()
    {
        Breathe breathe = new Breathe();
        breathe.DisplayStartingMessage();
        ShowAnimation(3);

    }
    public void ExecuteReflection()
    {
        Reflection reflect = new Reflection();
        reflect.DisplayStartingMessage();
        ShowAnimation(3);
    }
    public void ExecuteListing()
    {
        Listing list = new Listing();
        list.DisplayStartingMessage();
        ShowAnimation(3);
    }
}