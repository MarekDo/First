using System;
using System.Collections.Generic;
using System.Text;

namespace First.TasksList
{
    class TasksOfLessonqqqq
    {
        public string TaskLesson(int number)
        {
            List<string> lessonOneTasks = new List<string>();
            lessonOneTasks.Add("1. Wypisz w konsoli swoje imię i nazwisko, wykorzystując w tym celu wszystkie znane Ci metody wyświetlania komunikatów.");
            lessonOneTasks.Add("2. Utwórz dwie zmienne liczbowe i przypisz im wartości. Wyświetl w konsoli wyniki dodawania, odejmowania, mnożenia oraz dzielenia. Niech druga liczba nie będzie zerem. Użyj typu danych double. ");
            lessonOneTasks.Add("3. Utwórz dwie zmienne liczbowe i przypisz im wartości podane poprzez konsolę. Wyświetl w konsoli wyniki dodawania, odejmowania, mnożenia oraz dzielenia. Niech druga liczba nie będzie zerem. Użyj typu danych double.");
            lessonOneTasks.Add("4. Utwórz dwie zmienne liczbowe typu double. Dla każdego z działań (dodawanie, odejmowanie, mnożenie i dzielenie) przypisz z konsoli nowy zestaw liczb oraz wypisz ich wyniki w konsoli w formie pełnych działań arytmetycznych($”{ }”).");
            Console.WriteLine("lekcja z TaskLOfLessonqqq: " + lessonOneTasks[3]);
            return lessonOneTasks[number];
        }
    }
}
