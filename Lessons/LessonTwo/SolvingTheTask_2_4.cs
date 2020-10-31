using First.TasksList;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.Lessons.LessonTwo
{
    class SolvingTheTask_2_4
    {
        /*
        * Napisz program konsolowy, który sprawdzi, 
        * czy wartość pobrana z konsoli jest 
        * większa od 5 i mniejsza od 20. Wypisz wynik w konsoli.
        */

        public void Solving_2_4()
        {
            Console.Clear();
            Console.WriteLine("Lekcja nr 2, zadanie nr 4");

            ListOfTasksForLessonTwo listOfTasksForLessonTwo = new ListOfTasksForLessonTwo();
            Console.WriteLine(listOfTasksForLessonTwo.PrintLessonTwoTasks(4));

            int firstValue = 5;
            int secondValue = 20;
            int movingVariable;
            string stringMovingVariable;

            Console.WriteLine("Wprowadź wartość do porównania:");
            stringMovingVariable = Console.ReadLine();
            movingVariable = int.Parse(stringMovingVariable);

            if (movingVariable > firstValue && movingVariable < secondValue)
            {
                Console.WriteLine("podana wartość jest z przedziału pomiędzy 5 a 20");
            }
            else
            {
                Console.WriteLine("Podana wartość jest spoza zakresu 5 a 20");
            }
            Console.ReadKey();
        }
    }
}
