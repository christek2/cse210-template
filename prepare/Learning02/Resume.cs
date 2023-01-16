using System;

public class Resume
{
    public string _userName = "";
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_userName}");
        Console.WriteLine();
        Console.WriteLine($"Jobs:");
        foreach (Job i in _jobs)
        {
            i.Display();
        }
    }
}