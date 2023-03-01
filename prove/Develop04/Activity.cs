using System;

public class Activity
{
    private string _startingMessage;
    private string _endingMessage;
    private int _userTime;
    private string _userPrompt;

    public Activity(string startingMessage, string endingMessage)
    {
        _startingMessage = startingMessage;
        _endingMessage = endingMessage;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine(_startingMessage);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine(_endingMessage);
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
        Console.Write("\nFor how many seconds would you like to do this activity? ");
        string inputTime = Console.ReadLine();
        _userTime = int.Parse(inputTime);
        return _userTime;
    }
    public void ConvertToMil(int time)
    {
        int timeProportion = time / 60;
        int timeInMils = timeProportion * 1000;
        _userTime = timeInMils;
    }
    public void SetUserTime(int time)
    {
        _userTime = time;
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
        Console.Clear();
        DisplayStartingMessage();
        Breathe breathe = new Breathe(GetUserTime(), _startingMessage, _endingMessage);
        Console.Clear();
        Console.WriteLine("Ready?");
        ShowAnimation(3);
        breathe.LoopBreathe(_userTime);
        _endingMessage = $"Well done! \n\nYou have completed {_userTime} seconds of the Breathing activity.";
        DisplayEndingMessage();
        ShowAnimation(3);
    }
    public void ExecuteReflection()
    {
        // Console.Clear();
        // Reflection reflect = new Reflection();
        // reflect.DisplayStartingMessage();
        // ShowAnimation(3);
    }
    public void ExecuteListing()
    {
        // Console.Clear();
        // Listing list = new Listing();
        // list.DisplayStartingMessage();
        // ShowAnimation(3);
    }
}