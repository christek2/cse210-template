using System;

public class Manage
{
    private int _positionInTxt;
    private string _fileName;

    public Manage()
    {}

    public void AddAssets()
    {}
    public void RemoveAssets()
    {}
    public void EditAssets()
    {}
    public int GetPosition()
    {
        return _positionInTxt;
    }
    public void SetPosition(int position)
    {
        _positionInTxt = position;
    }
    public string GetFileName()
    {
        return _fileName;
    }
    public void SetProdLimit(string fileName)
    {
        _fileName = fileName;
    }
}