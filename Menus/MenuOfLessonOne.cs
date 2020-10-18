using System;
using System.Collections.Generic;
using System.Text;

namespace First.Menus
{
    class MenuOfLessonOne
    {
        public void PrintOnScreenMainMenu()
        {
            List<string> menuOne = new List<string>();
            menuOne.Add("1. Zadanie nr 1");
            menuOne.Add("2. Zadanie nr 2");
            menuOne.Add("3. Zadanie nr 3");
            menuOne.Add("4. Zadanie nr 4");
            menuOne.Add("5.Teskt poszczególnych zadań");
            menuOne.Add("0.Wyjście");


            Console.Clear();
            Console.WriteLine("Lekcja 1");
            
            foreach (string menu in menuOne)
            {
                Console.WriteLine(menu);
            }
   
            Console.WriteLine("Wprowadzony nr zatwierdź enterem");
        }
    }
}
