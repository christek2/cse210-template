using System;

public class Reflection : Activity
{
    private string _userPrompt;
    private List<string> _promptQuestions = new List<string>();

    public Reflection(string prompt)
    {}
    public Reflection(int time)
    {}
    public Reflection(string prompt, int time)
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
    {
        Random rand = new Random();
        int randIndex = rand.Next();
        Console.WriteLine();
    }
    public void GetQuestion() //set to string
    {}
    public void SetQuestion()
    {}
    public void DisplayQuestion()
    {}
}