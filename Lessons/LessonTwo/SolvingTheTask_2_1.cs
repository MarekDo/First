using First.TasksList;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.Lessons.LessonTwo
{
   
    public class SolvingTheTask_2_1
    {
        /*
        * Napisz program konsolowy, który spróbuje porównać ze sobą dwie zmienne typu int,
        * które zostaną zadeklarowane w kodzie programu. Zwróć uwagę na zachowanie programu
        * i wyświetlone komunikaty.
        */

        public void Solving_2_1()
        {
            Console.Clear();
            Console.WriteLine("Lekcja nr 2, zadanie nr 1");

            ListOfTasksForLessonTwo listOfTasksForLessonTwo = new ListOfTasksForLessonTwo();
            Console.WriteLine(listOfTasksForLessonTwo.PrintLessonTwoTasks(1));

            int firstValue = 45;
            int secondValue = 80;
            if (firstValue == secondValue)
            {
                Console.WriteLine(firstValue + " równe " + secondValue);
            }
            else if (firstValue < secondValue)
            {
                Console.WriteLine(firstValue + " jest mniejsze od " + secondValue);
            }
            else
                Console.WriteLine(firstValue + " jest większe " + secondValue);

            Console.ReadKey();
        }
    }
}
