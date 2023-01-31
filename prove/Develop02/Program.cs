using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu1 = new Menu();

        menu1._showMenu = true;
        while (menu1._showMenu == true)
        {
            menu1._userChoice = menu1.AcceptUserInput();
            menu1._showMenu = menu1.UserToMenu(menu1._userChoice);
        }
    }
}