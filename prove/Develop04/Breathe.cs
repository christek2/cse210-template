using System;

public class Breathe : Activity
{
    private string _message1;
    private string _message2;

    public Breathe()
    {
        SetUserTime(30);
    }
    public Breathe(int time)
    {
        SetUserTime(time);
    }

    public string GetMessage1()
    {
        return _message1;
    }
    public void SetMessage1(string message)
    {
        _message1 = message;
    }
    public void DisplayMessage1()
    {
        Console.WriteLine(_message1);
    }
    public string GetMessage2()
    {
        return _message2;
    }
    public void SetMessage2(string message)
    {
        _message2 = message;
    }
    public void DisplayMessage2()
    {
        Console.WriteLine(_message2);
    }
}