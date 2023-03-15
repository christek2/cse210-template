using System;

public class PointTracker
{
     private List<string> _goalList = new List<string>();

     public List<string> GetList()
     {
        return _goalList;
     }
     public void AddToList(string item)
     {
        _goalList.Add(item);
     }
}