using First.TasksList;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Xml.Serialization;

namespace First.Lessons.LessonOne
{
    public class SolvingTheTask_1_1
    {
        /*
        * Wypisz w konsoli swoje imię i nazwisko, wykorzystując
        * w tym celu wszystkie znane Ci metody wyświetlania komunikatów.
        */


        public void Solving_1_1()
        {
            Console.Clear();
            EnterUser enterUser = new EnterUser();
            enterUser.EnterName();
            enterUser.PrintDateOfUser();
            Console.ReadKey();
        }
    }
}
