using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace First.TasksList
{
    class ReadTaskOfLesson
    {
        TasksOfLessonqqqq tasksOfLessonqqqq = new TasksOfLessonqqqq();
        
        public void Printqqqq()
        {
            string tekst = (tasksOfLessonqqqq.TaskLesson(1));
            Console.WriteLine(tekst);
        }
    }
}
