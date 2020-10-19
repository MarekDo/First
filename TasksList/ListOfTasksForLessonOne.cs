using System;
using System.Collections.Generic;
using System.Text;

namespace First.TasksList
{
    public class ListOfTasksForLessonOne
    {
        private List<string> lessonOneTasks;
        public ListOfTasksForLessonOne()
        {
            lessonOneTasks = new List<string>();
            lessonOneTasks.Add("1. Wypisz w konsoli swoje imię i nazwisko, wykorzystując w tym celu wszystkie znane Ci metody wyświetlania komunikatów.");
            lessonOneTasks.Add("2. Utwórz dwie zmienne liczbowe i przypisz im wartości. Wyświetl w konsoli wyniki dodawania, odejmowania, mnożenia oraz dzielenia. Niech druga liczba nie będzie zerem. Użyj typu danych double. ");
            lessonOneTasks.Add("3. Utwórz dwie zmienne liczbowe i przypisz im wartości podane poprzez konsolę. Wyświetl w konsoli wyniki dodawania, odejmowania, mnożenia oraz dzielenia. Niech druga liczba nie będzie zerem. Użyj typu danych double.");
            lessonOneTasks.Add("4. Utwórz dwie zmienne liczbowe typu double. Dla każdego z działań (dodawanie, odejmowanie, mnożenie i dzielenie) przypisz z konsoli nowy zestaw liczb oraz wypisz ich wyniki w konsoli w formie pełnych działań arytmetycznych($”{ }”).");
        }
        public void PrintLessonOneTasks()
        {
            foreach(string leson in lessonOneTasks)
            {
                Console.WriteLine(leson);
            }
            Console.WriteLine("Powrót do listy - naciśnij dowolny klawisz");
            Console.ReadKey();
        }
        public string PrintLessonOneTasks(int numberOfLesson)
        {
            return lessonOneTasks[numberOfLesson - 1];
        }
    }
}
