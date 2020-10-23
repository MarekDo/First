using First.TasksList;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.Lessons.LessonTwo
{
    public class SolvingTheTask_2_2
    {

        public void Solving_2_2()
        {
            /*
             * Napisz program konsolowy, który porówna ze sobą dwie zmienne typu int ze zdefiniowanymi wartościami, 
             * które będą przez Ciebie podane w kodzie. Wypisz wynik porównania w konsoli.
             */
            Console.Clear();
            Console.WriteLine("Lekcja nr 2, zadanie nr 2");

            ListOfTasksForLessonTwo listOfTasksForLessonTwo = new ListOfTasksForLessonTwo();
            Console.WriteLine(listOfTasksForLessonTwo.PrintLessonTwoTasks(2));

            int firstValue;
            int secondValue;

            firstValue = 800;
            secondValue = 600;

            if (firstValue == secondValue)
            {
                Console.WriteLine(firstValue + " = " + secondValue);
            }
            else if (firstValue < secondValue)
            {
                Console.WriteLine(firstValue + " jest mniejsze od " + secondValue);
            }
            Console.WriteLine(firstValue + " jest większe od " + secondValue);
            Console.WriteLine("Wciśnij dowolny klawisz ...");
            Console.ReadKey();
        }
    }
}
