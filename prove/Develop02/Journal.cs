using System;

public class Journal
{
    public List<Entry> _userEntries = new List<Entry>();
    public string fileName = "";

    public void DisplayAll()
    {
        string fileName = "Journal.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
    public string LoadFile()
    {
        Console.WriteLine("Enter the name of the file you would like to load: ");
        Console.Write("> ");
        string userFile = Console.ReadLine();
        return userFile;
    }
    public void SaveEntry(List<Entry> entryList, Entry entry)
    {
        entryList.Add(entry);
    }
}