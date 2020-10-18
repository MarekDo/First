using System;
using System.Collections.Generic;
using System.Text;

namespace First.Menus
{
    class MenuOfLessonTwo
    {
        public void PrintOnScreenMainMenu()
        {
            List<string> menuTwo = new List<string>();
            menuTwo.Add("1. Zadanie nr 1");
            menuTwo.Add("2. Zadanie nr 2");
            menuTwo.Add("3. Zadanie nr 3");
            menuTwo.Add("4. Zadanie nr 4");
            menuTwo.Add("5. Zadanie nr 5");
            menuTwo.Add("6. Zadanie nr 6");
            menuTwo.Add("7. Zadanie nr 7");
            menuTwo.Add("8. Zadanie nr 8");
            menuTwo.Add("9.Teskt poszczególnych zadań");
            menuTwo.Add("0.Wyjście");

            Console.Clear();
            Console.WriteLine("Lekcja 2");

            foreach (string menu in menuTwo)
            {
                Console.WriteLine(menu);
            }

            Console.WriteLine("Wprowadzony nr zatwierdź enterem");
        }
    }
}
