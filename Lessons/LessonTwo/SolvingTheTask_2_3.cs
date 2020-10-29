using First.TasksList;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.Lessons.LessonTwo
{
    class SolvingTheTask_2_3
    {

        /*
         * Napisz program konsolowy, który porówna ze sobą dwie zmienne typu int, 
         * których wartości zostaną pobrane z konsoli. 
         * Wypisz wynik porównania w konsoli.
         */

        public void Solving_2_3()
        {

            Console.Clear();
            Console.WriteLine("Lekcja nr 2, zadanie nr 3");

            ListOfTasksForLessonTwo listOfTasksForLessonTwo = new ListOfTasksForLessonTwo();
            Console.WriteLine(listOfTasksForLessonTwo.PrintLessonTwoTasks(3));

            int firstValue;
            int secondValue;
            string stringValue;

            Console.WriteLine("Wprowadź dwie liczby całkowite ");
            Console.WriteLine("Wprowadź pierwszą liczbę: ");
            stringValue = Console.ReadLine();
            firstValue = int.Parse(stringValue);
            Console.WriteLine("Wskazana wartość do porównania to: " + firstValue);
            Console.WriteLine("Podaj drugą liczbę: ");
            stringValue = Console.ReadLine();
            secondValue = int.Parse(stringValue);
            Console.WriteLine("Druga liczba do porównania to: " + secondValue);
            Console.WriteLine("porównanie ...");

            if (firstValue == secondValue)
            {
                Console.WriteLine(firstValue + " i " + secondValue + "są takie same");
            }
            else if (firstValue < secondValue)
            {
                Console.WriteLine(firstValue + " jest mniejsze od " + secondValue);
            }
            else if (firstValue > secondValue)
                Console.WriteLine(firstValue + " jest większe od " + secondValue);

            Console.WriteLine("Wcosnij dowolny klawisz ...");
            Console.ReadKey();
        }
    }
}
