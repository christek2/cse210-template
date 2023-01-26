using System.IO;

public class Entry
{
    public string _entryDate = "";
    public int _length;

    public void WriteNew()
    {
        Prompt prompt1 = new Prompt();
        prompt1.CompileList();
        prompt1.DisplayRandom();

        Console.Write(">");
        string newEntry = Console.ReadLine();
    }
    public void SaveEntry()
    {}
    public void LoadEntry()
    {}
}