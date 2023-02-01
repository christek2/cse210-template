using System;

public class Prompt
{
    public string _promptA = "What did you have for breakfast?";
    public string _promptB = "What do you wish you could go back and do differently from today?";
    public string _promptC = "What was the most interesting conversation you had today?";
    public string _promptD = "Whis is one thing that you learned today?";
    public string _promptE = "What's a goal you would like to set in your daily routine?";
    public List<string> _promptBank = new List<string>();

    public void CompileList()
    {
        _promptBank.Add(_promptA);
        _promptBank.Add(_promptB);
        _promptBank.Add(_promptC);
        _promptBank.Add(_promptD);
        _promptBank.Add(_promptE);
    }
    public void PrintList()
    {
        foreach (string i in _promptBank)
        {
            Console.WriteLine(i);
        }
    }
    public string DisplayRandom()
    {
        Random randNum = new Random();
        int num = randNum.Next(0, 5);
        string randPrompt = _promptBank[num];
        return randPrompt;
    }
}