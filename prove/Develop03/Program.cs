using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Word word1 = new Word();
        string userWord = word1.ReplaceWord("baby");
        Console.WriteLine(userWord);

        Scripture testScripture = new Scripture();
        List<string> testList = testScripture.CompileList("thing thing thing thing thing thing thing thing thing thing thing thing thing thing thing thing thing thing thing thing");
        testScripture.HideWords("yes", testList);
    
    }
}