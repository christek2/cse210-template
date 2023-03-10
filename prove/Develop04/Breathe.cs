using System;

public class Breathe : Activity
{
    private string _message1;
    private string _message2;

    public Breathe(string startingMessage, string endingMessage) : base (startingMessage, endingMessage)
    {
        SetUserTime(30);
        _message1 = "Breathe in...";
        _message2 = "Breathe out...";
    }
    public Breathe(int time, string startingMessage, string endingMessage) : base (startingMessage, endingMessage)
    {
        SetUserTime(time);
        _message1 = "Breathe in...";
        _message2 = "Breathe out...";
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
    public void LoopBreathe(int userTime)
    {
        
        float splitTime = userTime / 3;
        for (int i = 0; i < 3; i ++ )
        {
            DisplayMessage1(); 
            for (int startTime = (int)Math.Round(splitTime) / 2; startTime > 0; startTime--)
            {
                Console.Write(startTime);
                Thread.Sleep(1000);
                Console.Write("\b\b");
            }
            
            DisplayMessage2();
            for (int startTime = (int)Math.Round(splitTime) / 2; startTime > 0; startTime--)
            {
                Console.Write(startTime);
                Thread.Sleep(1000);
                Console.Write("\b\b");
            }
        }
    }
}