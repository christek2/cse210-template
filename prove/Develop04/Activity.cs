using System;

public class Activity
{
    private string _startingMessage;
    private string _endingMessage;
    private int _userTime;

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
    public void ShowAnimation(int milsecond)
    {
        int repeat = 1;
        while (repeat < 5)
        {
            Console.Write("|");
            Thread.Sleep(milsecond);
            Console.Write("\b\b");
            Console.Write("(");
            Thread.Sleep(milsecond);
            Console.Write("\b\b");
            Console.Write("|");
            Thread.Sleep(milsecond);
            Console.Write("\b\b");
            Console.Write(")");
            Thread.Sleep(milsecond);
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
        _userTime = time;
    }
    // public string GetPrompt()
    // {}
    // public void SetPrompt()
    // {}
    // public void DisplayPrompt()
    // {}
}