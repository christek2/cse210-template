using System;

public class Counter
{
    public int _entryStreak;
    public int _userGoal;
    public List<string> _streakList = new List<string>();

    public int GetEntryCount(List<Entry> entryList)
    {
        Journal journal1 = new Journal();
        entryList = journal1._userEntries;
        foreach (Entry item in entryList)
        {
            string listItem = item.ToString();
            _streakList.Add(listItem);
        }

        int streak = _streakList.Count;
        return streak;
    }
    public string CompareStreakGoal(int streak)
    {
        if (streak > _userGoal)
        {
            int difference = streak - _userGoal;
            string systemResponse = $"Well done! You are {difference} days ahead of your goal!";
            return systemResponse;
        }
        else if (_userGoal > streak)
        {
            int difference = _userGoal - streak;
            string systemResponse = $"Keep it up! You are only {difference} days away from your goal!";
            return systemResponse;
        }
        else if (_userGoal == streak)
        {
            string systemResponse = "Good job! You have reached your goal!";
            return systemResponse;
        }
        else
        {
            string systemResponse = "Error";
            return systemResponse;
        }
    }
    public int ResetUserGoal()
    {
        Console.WriteLine();
        Console.WriteLine("Would you like to reset your goal?");
        Console.Write("> ");
        string userResponse = Console.ReadLine();
        if (userResponse == "Yes")
        {
            Console.WriteLine();
            Console.WriteLine("What is your goal?");
            Console.Write("> ");
            string goal = Console.ReadLine();
            int _userGoal = int.Parse(goal);
            return _userGoal;
        }
        else if (userResponse == "No")
        {
            Console.WriteLine();
            Console.WriteLine("Okay");
            return _userGoal;
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Error");
            return _userGoal;
        }
    }
    public void DisplayCount(int streak, int goal)
    {
        Console.WriteLine($"Current Goal: {streak}     Current Streak: {goal}");
    }
}