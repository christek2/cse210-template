using System;

public class Listing : Activity
{
    private string _userPrompt;

    public Listing()
    {}
    public Listing(int time)
    {}

    public string GetPrompt()
    {
        return _userPrompt;
    }
    public void SetPrompt(string prompt)
    {
        _userPrompt = prompt;
    }
    public void DisplayPrompt()
    {}
}