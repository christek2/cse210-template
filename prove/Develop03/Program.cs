using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture testScripture = new Scripture();
        string text = "And I was led by the Spirit, not knowing beforehand the things which I should do";
        testScripture.SetText(text);
        Console.WriteLine(text);

        Console.Write("Press enter to continue (type 'quit' to exit): ");
            string userInput = Console.ReadLine();
            Console.WriteLine();
        
        bool repeat = true;
        while (repeat)
        {
            string script = testScripture.GetText();
            
            string newScript = testScripture.HideWords(userInput, testScripture.CompileList(script));
            Console.WriteLine(newScript);
            
            Console.Write("Press enter to continue (type 'quit' to exit): ");
            userInput = Console.ReadLine();
            Console.WriteLine();

            if (userInput == "quit")
            {
                repeat = false;
            }
            else{}

            testScripture.SetText(newScript);
        }

    }
}