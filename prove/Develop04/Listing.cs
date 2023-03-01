using System;

public class Listing : Activity
{
    private string _userPrompt;

    public Listing(string startingMessage, string endingMessage) : base (startingMessage, endingMessage)
    {}
    public Listing(int time, string startingMessage, string endingMessage) : base (startingMessage, endingMessage)
    {}
    public override void SetPrompt(string prompt)
    {
        _userPrompt = prompt;
    }
}