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

    public string GetText()
    {
        return _scriptureText;
    }
    public void SetText(string scripture)
    {
        _scriptureText = scripture;
    }
    public List<string> CompileList(string scripture)
    {
        _scriptureWords.Clear();
        string[] scriptureWord = scripture.Split(' ');
        foreach (string i in scriptureWord)
        {
            _scriptureWords.Add(i);
        }
        return _scriptureWords;
    }
    public string HideWords(string userChoice, List<string> wordList)
    {
        if (userChoice == "")
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

            num1 = num1 -1;
            num2 = num2 -1;
            num3 = num3 - 1;
            max = max - 2;

            string word1 = wordList[num1];
            string word2 = wordList[num2];
            string word3 = wordList[num3];

            Word replaceWord = new Word();
            string replacementWord1 = replaceWord.ReplaceWord(word1);
            string replacementWord2 = replaceWord.ReplaceWord(word2);
            string replacementWord3 = replaceWord.ReplaceWord(word3);

            if (replaceWord.IfHidden(word1) == false)
            {
            wordList.RemoveAt(num1);
            wordList.Insert(num1, replacementWord1);
            }
            if (replaceWord.IfHidden(word2) == false)
            {
            wordList.RemoveAt(num2);
            wordList.Insert(num2, replacementWord2);
            }
            if (replaceWord.IfHidden(word3) == false)
            {
            wordList.RemoveAt(num3);
            wordList.Insert(num3, replacementWord3);
            }

            string newScripture = string.Join(" ", wordList.ToArray());
            return newScripture;
        }
        else if (userChoice == "quit")
        {
            return "Okay!";
        }
        else
        {
            return $"Sorry, {userChoice} is not an acceptable answer, please type 'yes' or 'no'";
        }
    }
}