using System;
using System.Collections.Generic;
using System.Text;

namespace First.Menus
{
    class MenuOfLessonThree
    {
        public void PrintOnScreenMainMenu()
        {
            List<string> menuThree = new List<string>();
            menuThree.Add("1. Zadanie nr 1");
            menuThree.Add("2. Zadanie nr 2");
            menuThree.Add("3. Zadanie nr 3");
            menuThree.Add("4. Zadanie nr 4");
            menuThree.Add("5. Zadanie nr 5");
            menuThree.Add("6. Zadanie nr 6");
            menuThree.Add("7. Zadanie nr 7");
            menuThree.Add("8. Zadanie nr 8");
            menuThree.Add("9.Teskt poszczególnych zadań");
            menuThree.Add("0.Wyjście");

            Console.Clear();
            Console.WriteLine("Lekcja 3");

            foreach (string menu in menuThree)
            {
                Console.WriteLine(menu);
            }

            Console.WriteLine("Wprowadzony nr zatwierdź enterem");
        }
    }
}
