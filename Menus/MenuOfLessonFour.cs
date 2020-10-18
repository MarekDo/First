using System;
using System.Collections.Generic;
using System.Text;

namespace First.Menus
{
    public class MenuOfLessonFour
    {
        public void PrintOnScreenMainMenu()
        {
            List<string> menuFour = new List<string>();
            menuFour.Add("1. Zadanie nr 1");
            menuFour.Add("2. Zadanie nr 2");
            menuFour.Add("3. Zadanie nr 3");
            menuFour.Add("4. Zadanie nr 4");
            menuFour.Add("5. Zadanie nr 5");
            menuFour.Add("6. Zadanie nr 6");
            menuFour.Add("7. Zadanie nr 7");
            menuFour.Add("8. Zadanie nr 8");
            menuFour.Add("9. Zadanie nr 9");
            menuFour.Add("10. Zadanie nr 10");
            menuFour.Add("11. Zadanie nr 11");
            menuFour.Add("12. Zadanie nr 12");
            menuFour.Add("13. Zadanie nr 13");
            menuFour.Add("14. Zadanie nr 14");
            menuFour.Add("15. Zadanie nr 15");
            menuFour.Add("16. Zadanie nr 16");
            menuFour.Add("17. Zadanie nr 17");
            menuFour.Add("18. Zadanie nr 18");
            menuFour.Add("19.Teskt poszczególnych zadań");
            menuFour.Add("0.Wyjście");

            Console.Clear();
            Console.WriteLine("Lekcja 4");

            foreach (string menu in menuFour)
            {
                Console.WriteLine(menu);
            }

            Console.WriteLine("Wprowadzony nr zatwierdź enterem");
        }
    }
}
