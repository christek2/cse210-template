using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture testScripture = new Scripture();
        Reference testRef = new Reference(6);
        testRef.SetReference("1 Nephi", 4, 6);
        string reference = "";

        Console.Clear();
        Console.WriteLine("Press enter to use the current loaded scripture, or type a new scripture");
        string answer = Console.ReadLine();
        string text = "";
        if (answer == "")
        {
            reference = testRef.GetReference();
            text = "And I was led by the Spirit, not knowing beforehand the things which I should do";
        }
        else
        {
            Console.Write("Enter the reference here: ");
            reference = Console.ReadLine();
            text = answer;
        }

        testScripture.SetText(text);
        Console.Clear();
        Console.WriteLine($"{reference}  {text}");

        Console.Write("Press enter to continue (type 'quit' to quit): ");
            string userInput = Console.ReadLine();
            Console.WriteLine();
        
        bool repeat = true;
        while (repeat)
        {
            string script = testScripture.GetText();
            
            string newScript = testScripture.HideWords(userInput, testScripture.CompileList(script));
            Console.Clear();
            Console.WriteLine($"{reference}  {newScript}");
            
            Console.Write("Press enter to continue (type 'quit' to quit): ");
            userInput = Console.ReadLine();
            Console.WriteLine();

            testScripture.SetText(newScript);

            if (userInput == "quit" || testScripture.ScriptHidden(newScript) == true)
            {
                repeat = false;
            }
            else{}
        }

    }
}