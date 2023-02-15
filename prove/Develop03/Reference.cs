using System;

public class Reference
{
    private string _scriptureReference;
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(int verse)
    {
        _book = "";
        _chapter = 0;
        _verse = verse;
    }
    public Reference(int verse1, int verse2)
    {
        _book = "";
        _chapter = 0;
        _verse = verse1;
        _endVerse = verse2;
    }

    public string GetReference()
    {
        return _scriptureReference;
    }
    public void SetReference(string book, int chapter, int verse, int endVerse = 0)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
        if (endVerse == 0)
        {
            _scriptureReference = $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            _scriptureReference = $"{_book} {chapter}:{_verse}-{_endVerse}";
        }
    }
}