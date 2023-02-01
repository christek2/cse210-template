using System.IO;

public class Entry
{
    public string _entryPrompt = "";
    public string _entryDate = "";
    public string _entryData;

    public Entry WriteNew(string date, string prompt)
    {
        string fileName = "Journal.txt"; 
        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            outputFile.WriteLine();

            Console.WriteLine(prompt);

            Console.Write("> ");
            string newEntry = Console.ReadLine();

            outputFile.WriteLine(date);
            outputFile.WriteLine($"Prompt: {prompt}");
            outputFile.WriteLine($"> {newEntry}");

            Entry entry1 = new Entry();
            entry1._entryDate = date;
            entry1._entryPrompt = prompt;
            entry1._entryData = newEntry;

            return entry1;
        }
    }
    public string GetDate()
    {
        DateTime currentDate = DateTime.Now;
        string entryDate = currentDate.ToShortDateString();
        return entryDate;
    }
    public string GetPrompt()
    {
        Prompt prompt1 = new Prompt();
        prompt1.CompileList();
        string entryPrompt = prompt1.DisplayRandom();
        return entryPrompt;
    }
}