using System;
using System.Collections.Generic;
using System.Text;

namespace First.ToDoList
{
    public class ListOfTasksForLessonTwo
    {
        public void PrintLessonTwoTasks()
        {
            List<string> lessonTwoTasks = new List<string>();
            lessonTwoTasks.Add("1. Napisz program konsolowy, który spróbuje porównać ze sobą dwie zmienne typu int, które zostaną zadeklarowane w kodzie programu. Zwróć uwagę na zachowanie programu i wyświetlone komunikaty.");
            lessonTwoTasks.Add("2. Napisz program konsolowy, który porówna ze sobą dwie zmienne typu int ze zdefiniowanymi wartościami, które będą przez Ciebie podane w kodzie. Wypisz wynik porównania w konsoli.");
            lessonTwoTasks.Add("3. Napisz program konsolowy, który porówna ze sobą dwie zmienne typu int, których wartości zostaną pobrane z konsoli. Wypisz wynik porównania w konsoli.");
            lessonTwoTasks.Add("4. Napisz program konsolowy, który sprawdzi, czy wartość pobrana z konsoli jest większa od 5 i mniejsza od 20. Wypisz wynik w konsoli.");
            lessonTwoTasks.Add("5. Napisz program konsolowy, który sprawdzi, czy wartość pobrana z konsoli jest spoza zakresu <5; 20>. Wypisz wynik w konsoli.");
            lessonTwoTasks.Add("6. Napisz program konsolowy, który pobierze z konsoli dwie liczby całkowite, po czym do trzeciej zmiennej przypisze większą wartość. Wykorzystaj przypisanie warunkowe i wypisz wynik w konsoli.");
            lessonTwoTasks.Add("7. Napisz program konsolowy, który pobierze z konsoli długości trzech boków trójkąta. Sprawdź, czy z podanych wartości można utworzyć trójkąt. Wypisz wynik w konsoli.");
            lessonTwoTasks.Add("8. Napisz program konsolowy, który pobierze dwie wartości z konsoli. Wyświetl w konsoli wyniki dodawania, odejmowania, mnożenia oraz dzielenia. Pamiętaj, żeby przy próbie dzielenia przez 0 wyświetlić odpowiedni komunikat, który uniemożliwi przeprowadzenie „zakazanego” działania. Użyj typu danych double.");
            
            Console.WriteLine();
            foreach (string lesson in lessonTwoTasks)
            {
                Console.WriteLine(lesson);
            }
        }

    }
}
