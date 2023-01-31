using System;

public class Journal
{
    public List<string> _userEntries = new List<string>();
    public string _fileName;

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
    public void SaveEntry(Entry entry)
    {
        string fileName = "Journal.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            outputFile.WriteLine();
            outputFile.WriteLine(entry._entryDate);
            outputFile.WriteLine($"Prompt: {entry._entryPrompt}");
            outputFile.WriteLine($"> {entry._entryData}");
        }
    }
}