using System;

public class Reflection : Activity
{
    private string _userPrompt;
    private string _userQuestion;

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
    public void SetPrompt()
    {
        List<string> promptList = new List<string>();
        promptList.Add("");
        promptList.Add("");
        promptList.Add("");
        promptList.Add("");
        promptList.Add("");
        Random rand = new Random();
        int max = promptList.Count;
        int randIndex = rand.Next(0, max);
        _userPrompt = promptList[randIndex];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine(_userPrompt);
    }
    public string GetQuestion()
    {
        return _userQuestion;
    }
    public void SetQuestion()
    {
        List<string> questionList = new List<string>();
        questionList.Add("");
        questionList.Add("");
        questionList.Add("");
        questionList.Add("");
        questionList.Add("");
        Random rand = new Random();
        int max = questionList.Count;
        int randIndex = rand.Next(0, max);
        _userQuestion = questionList[randIndex];
    }
    public void DisplayQuestion()
    {
         Console.WriteLine(_userQuestion);
    }
}