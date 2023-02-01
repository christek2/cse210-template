using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu1 = new Menu();

        menu1._showMenu = true;
        while (menu1._showMenu == true)
        {
            Journal journal1 = new Journal();
            Counter counter1 = new Counter();
            int streak = counter1.GetEntryCount(journal1._userEntries);
            counter1.DisplayCount(streak, counter1._userGoal);
            menu1._userChoice = menu1.AcceptUserInput();
            menu1._showMenu = menu1.UserToMenu(menu1._userChoice);
        }
    }
}