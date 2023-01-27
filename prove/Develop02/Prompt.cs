using System;

public class Prompt
{
    public string _promptA = "This is A";
    public string _promptB = "This is B";
    public string _promptC = "This is C";
    public string _promptD = "This is D";
    public string _promptE = "This is E";
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