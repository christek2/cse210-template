using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        string run = "M";
        while (run == "M" || run == "m")
        {
            run = menu.DisplayInterface();
        }
    }
}