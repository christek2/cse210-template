using System;

public class Scripture
{

    private List<string> _scriptureWords = new List<string>();
    private string _scriptureText;

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
            int max = wordList.Count;
            Random randomNum = new Random();
            Word replaceWord = new Word();


            int num1 = randomNum.Next(0, max);
            bool hidden1 = true;
            string test1;
            while (hidden1 == true)
            {
                num1 = randomNum.Next(0, max);
                test1 = wordList[num1];
                hidden1 = replaceWord.IfHidden(test1);
            }
            
            int num2 = randomNum.Next(0, max);
            bool hidden2 = true;
            string test2;
            while (hidden2 == true && num2 == num1)
            {
                num2 = randomNum.Next(0, max);
                test2 = wordList[num2];
                hidden2 = replaceWord.IfHidden(test2);
            }

            int num3 = randomNum.Next(0, max);
            bool hidden3 = true;
            string test3;
            while (hidden3 == true && (num3 == num2 || num3 == num1))
            {
                num3 = randomNum.Next(0, max);
                test3 = wordList[num3];
                hidden3 = replaceWord.IfHidden(test3);
            }
            
            string word1 = wordList[num1];
            string word2 = wordList[num2];
            string word3 = wordList[num3];

            string replacementWord1 = replaceWord.ReplaceWord(word1);
            string replacementWord2 = replaceWord.ReplaceWord(word2);
            string replacementWord3 = replaceWord.ReplaceWord(word3);

            wordList.RemoveAt(num1);
            wordList.Insert(num1, replacementWord1);
        
            wordList.RemoveAt(num2);
            wordList.Insert(num2, replacementWord2);
            
            wordList.RemoveAt(num3);
            wordList.Insert(num3, replacementWord3);

            string newScripture = string.Join(" ", wordList.ToArray());
            return newScripture;
        }
        else if (userChoice == "quit")
        {
            return "";
        }
        else
        {
            return $"Sorry, {userChoice} is not an acceptable answer";
        }
    }
    public bool ScriptHidden(string check)
    {
        bool hidden = true;
        List<string> checkList = CompileList(check);
        string checkString = string.Join("", checkList.ToArray());
        foreach (char i in checkString)
        {
            string j = Char.ToString(i);
            if (j != "_")
            {
                hidden = false;
                break;
            }
        }

        return hidden;
    }
}