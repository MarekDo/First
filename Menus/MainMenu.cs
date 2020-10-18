using System;
using System.Collections.Generic;
using System.Text;

namespace First.Menus
{
    class MainMenu
    {
        public void PrintOnScreenMainMenu()
        {
            List<string> listOfmainMenu = new List<string>();
            listOfmainMenu.Add("1. Lekcja nr 1.");
            listOfmainMenu.Add("2. Lekcja nr 2.");
            listOfmainMenu.Add("3. Lekcja nr 3.");
            listOfmainMenu.Add("4. Lekcja nr 4.");


            Console.Clear();
            Console.WriteLine("Lekcje C#");
            Console.WriteLine("Podaj nr lekcji");
            foreach (string mainMenu in listOfmainMenu)
            {
                Console.WriteLine(mainMenu);
            }
            Console.WriteLine("15. Zakończ program.");
            Console.WriteLine("Wprowadzony nr zatwierdź enterem");
            
        }
    }
}
