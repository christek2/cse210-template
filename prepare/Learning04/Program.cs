using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment test = new Assignment("Kimball", "Accounting");
       Console.WriteLine(test.GetSummary());

       MathAssignment math1 = new MathAssignment("Kimball", "Accounting", "10", "1-12");
       Console.WriteLine(math1.GetSummary());
       Console.WriteLine(math1.GetHomeworkList());

       WritingAssignment write1 = new WritingAssignment("Kimball", "History", "World History");
       Console.WriteLine(write1.GetSummary());
       Console.WriteLine(write1.GetWritingInformation());

    }
}