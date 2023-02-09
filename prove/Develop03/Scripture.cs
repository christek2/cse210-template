using System;

public class Scripture
{

    private List<string> _scriptureWords = new List<string>();
    private string _scriptureText;
    private Reference _scriptureReference;

    public Scripture()
    {}
    public Scripture(string first, string last)
    {}

    public string GetText(string scripture)
    {
        return _scriptureText;
    }
    public List<string> CompileList(string scripture)
    {
        string[] scriptureWord = scripture.Split(' ');
        foreach (string i in scriptureWord)
        {
            _scriptureWords.Add(i);
        }
        return _scriptureWords;
    }
    public void HideWords(string userChoice, List<string> wordList)
    {
        if (userChoice == "yes")
        {
            int max = wordList.Count + 1;
            Random randomNum = new Random();
            int num1 = randomNum.Next(1, max);
            int num2 = num1 + 1;
            int num3 = num1 - 1;
            if (num1 + 1 == max || num1 == max)
            {
                num2 = num1 - 1;
                num3 = num2 - 1;
                
            }
            else if (num1 - 1 == 1 || num1 == 1)
            {
                num2 = num1 + 1;
                num3 = num2 + 1;
            }

            Console.WriteLine($"{max}, {num1}, {num2}, {num3}");
        }
    }
}