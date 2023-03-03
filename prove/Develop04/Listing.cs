using System;

public class Listing : Activity
{
    private string _userPrompt;
    private List<string> _promptList = new List<string>();

    public Listing(string startingMessage, string endingMessage) : base (startingMessage, endingMessage)
    {
        _promptList.Add("Who are the people that you appreciate?");
        _promptList.Add("What are personal strengths of yours?");
        _promptList.Add("Who are the people that you have helped this week?");
        _promptList.Add("When have you felt the Holy Ghost this month?");
        _promptList.Add("Who are some of your personal heroes?");
    }
    public Listing(int time, string startingMessage, string endingMessage) : base (startingMessage, endingMessage)
    {
        SetUserTime(time);

        _promptList.Add("Who are the people that you appreciate?");
        _promptList.Add("What are personal strengths of yours?");
        _promptList.Add("Who are the people that you have helped this week?");
        _promptList.Add("When have you felt the Holy Ghost this month?");
        _promptList.Add("Who are some of your personal heroes?");
    }
    public override void SetPrompt(string prompt)
    {
        Random rand = new Random();
        int max = _promptList.Count;
        int randIndex = rand.Next(0, max);
        _userPrompt = _promptList[randIndex];
    }
    public void LaunchListing(int time)
    {
        SetPrompt(_userPrompt);
        Console.WriteLine($"---{_userPrompt}---");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);

        Thread.Sleep(4000);
        Console.WriteLine("Begin:");

        List<string> itemList = new List<string>();
        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            itemList.Add(item);
            currentTime = DateTime.Now;
        }
        Console.WriteLine($"You recorded {itemList.Count} items!");
        Console.WriteLine();
    }
}