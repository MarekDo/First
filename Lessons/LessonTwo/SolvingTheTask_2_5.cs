using First.TasksList;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.Lessons.LessonTwo
{
    class SolvingTheTask_2_5
    {

        public void Solving_2_5()
        {
            Console.WriteLine("Lekcja nr 2, zadanie nr 5");

            ListOfTasksForLessonTwo listOfTasksForLessonTwo = new ListOfTasksForLessonTwo();
            Console.WriteLine(listOfTasksForLessonTwo.PrintLessonTwoTasks(5));

            Console.WriteLine("TODO - zrobić");
            Console.ReadKey();
        }
    }
}
