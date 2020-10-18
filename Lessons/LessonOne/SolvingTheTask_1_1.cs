using First.TasksList;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.Lessons.LessonOne
{
    public class SolvingTheTask_1_1
    {
        

        public void Solving_1_1()
        {

            ListOfTasksForLessonOne listOfTasksForLessonOne = new ListOfTasksForLessonOne();
            
            /*
             * Wypisz w konsoli swoje imię i nazwisko, wykorzystując
             * w tym celu wszystkie znane Ci metody wyświetlania komunikatów.
            */

            EnterUser enterUser = new EnterUser();
            enterUser.EnterName();
            enterUser.PrintDateOfUser();
            Console.ReadKey();
        }
    }
}
