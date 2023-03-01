using System;

public class Reflection : Activity
{
    private string _userPrompt;
    private List<string> _promptList = new List<string>();
    private string _userQuestion;
    private List<string> _questionList = new List<string>();

    public Reflection(string prompt, string startingMessage, string endingMessage) : base (startingMessage, endingMessage)
    {
        SetUserTime(30);
        _userPrompt = prompt;
    }
    public Reflection(string startingMessage, string endingMessage) : base (startingMessage, endingMessage)
    {
        SetUserTime(30);
        _promptList.Add("Think of a time when you did something really difficult.");
        _promptList.Add("Think of a time when you helped someone in need.");
        _promptList.Add("Think of a time when you did something truly selfless.");

        _questionList.Add("Why was this experience meaningful to you?");
        _questionList.Add("How did you get started?");
        _questionList.Add("What made this time different than other times when you were not successful?");
        _questionList.Add("What could you learn from this experience that applies to other situations?");
        _questionList.Add("How can you keep this experience in mind in the future?");
        _questionList.Add("What is your favorite thing about this experience?");
        _questionList.Add("How did feel when it was complete?");
    }
    public Reflection(string prompt, int time, string startingMessage, string endingMessage) : base (startingMessage, endingMessage)
    {
        SetUserTime(time);
        _userPrompt = prompt;
    }
    public override void SetPrompt(string prompt)
    {
        Random rand = new Random();
        int max = _promptList.Count;
        int randIndex = rand.Next(0, max);
        _userPrompt = _promptList[randIndex];
    }
    public string GetQuestion()
    {
        return _userQuestion;
    }
    public void SetQuestion()
    {
        Random rand = new Random();
        int max = _questionList.Count;
        int randIndex = rand.Next(0, max);
        _userQuestion = _questionList[randIndex];
    }
    public void DisplayQuestion()
    {
         Console.WriteLine(_userQuestion);
    }
}