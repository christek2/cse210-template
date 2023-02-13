using System;

public class Word
{

    private List<string> _lettersInWord = new List<string>();
    private string _wordText;

    public Word(){}

    public string ReplaceWord(string word)
    {
        int length = CountLetters(word);
        string newWord = string.Concat(Enumerable.Repeat("_", length));
        return newWord;
    }
    public int CountLetters(string word)
    {
        int count = word.Length;
        return count;
    }
    public bool IfHidden(string word)
    {
        string item = word.Substring(0,1);
        if (item == "_")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}