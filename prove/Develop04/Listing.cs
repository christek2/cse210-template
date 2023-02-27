using System;

public class Listing : Activity
{
    private string _userPrompt;

    public Listing()
    {}
    public Listing(int time)
    {}
    public override void SetPrompt(string prompt)
    {
        _userPrompt = prompt;
    }
}