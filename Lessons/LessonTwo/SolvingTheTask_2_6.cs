using First.TasksList;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.Lessons.LessonTwo
{
    class SolvingTheTask_2_6
    {

            /*
             * Napisz program konsolowy, który pobierze z konsoli dwie liczby całkowite, 
             * po czym do trzeciej zmiennej przypisze większą wartość. 
             * Wykorzystaj przypisanie warunkowe i wypisz wynik w konsoli.
             */

        public void Solving_2_6()
        {
            Console.Clear();
            Console.WriteLine("Lekcja nr 2, zadanie nr 6");
            Console.WriteLine("");

            ListOfTasksForLessonTwo listOfTasksForLessonTwo = new ListOfTasksForLessonTwo();
            Console.WriteLine(listOfTasksForLessonTwo.PrintLessonTwoTasks(6));

            int firstValue;
            int secondValue;
            int greaterValue;
            string movingValue;

            Console.WriteLine("Podaj pierwszą liczbę:");
            movingValue = Console.ReadLine();
            firstValue = int.Parse(movingValue);
            Console.WriteLine("Wprowadź drugą wartość:");
            movingValue = Console.ReadLine();
            secondValue = int.Parse(movingValue);

            if (firstValue == secondValue)
            {
                Console.WriteLine("obie rartości są takie same");
                greaterValue = firstValue;
            }
            else if (firstValue < secondValue)
            {
                greaterValue = secondValue;
                Console.WriteLine("Wieksza wartośc to: " + greaterValue);
            }
            else
            {
                greaterValue = firstValue;
                Console.WriteLine("Większa wartość to: " + greaterValue);
            }

         Console.ReadKey();
        }
    }
}
