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
        _promptList.Add("Think of a time when you did something really difficult");
        _promptList.Add("Think of a time when you helped someone in need");
        _promptList.Add("Think of a time when you did something truly selfless");

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
    public override string GetPrompt()
    {
        return _userPrompt;
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
    public void LaunchActivity(int time)
    {
        SetPrompt(_userPrompt);
        string prompt = GetPrompt();

        Console.WriteLine("Consider the following:");
        Console.WriteLine();
        Console.WriteLine($"---{prompt}---");
        Console.WriteLine();
        
        Console.WriteLine("Press enter to continue when ready ");
        string userInput = Console.ReadLine();
        while (userInput != "")
        {
            userInput = Console.ReadLine();
        }

        Console.WriteLine("Ponder on the following questions. \nYou may begin in: ");
        for (int i = 5; i > 0; i--)
            {
                Console.Write("\b\b");
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b\b");
            }

        Console.Clear();
        LoopQuestions(time);
    }
    private void LoopQuestions(int time)
        {
            float questionTime = time / 3;
            int qTime = (int)Math.Round(questionTime);
            SetQuestion();
            string q1 = GetQuestion();
            SetQuestion();
            string q2 = GetQuestion();
            while (q1 == q2)
            {
                SetQuestion();
                q2 = GetQuestion();
            }
            SetQuestion();
            string q3 = GetQuestion();
            while (q3 == q2 || q3 == q2)
            {
                SetQuestion();
                q3 = GetQuestion();
            }

            Console.WriteLine(q1);
            ShowAnimation(qTime);
            Console.WriteLine(q2);
            ShowAnimation(qTime);
            Console.WriteLine(q3);
            ShowAnimation(qTime);
        }
}