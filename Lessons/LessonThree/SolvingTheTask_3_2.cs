using First.TasksList;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.Lessons.LessonThree
{
    class SolvingTheTask_3_2
    {
            /*
             * Wykonaj Zad. 1. modyfikując strukturę if…else na if…else if…else. Dostrzegasz różnicę?
             */

        public void Solving_3_2()
        {

            Console.Clear();
            Console.WriteLine("Lekcja nr 3, zadanie nr 2");
            Console.WriteLine("");

            ListOfTasksForLessonThree listOfTasksForLessonThree = new ListOfTasksForLessonThree();
            Console.WriteLine(listOfTasksForLessonThree.PrintLessonThreeTasks(2));

            Console.WriteLine("TODO .....");

            Console.ReadKey();
        }
    }
}
