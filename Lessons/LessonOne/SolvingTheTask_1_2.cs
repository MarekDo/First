using First.TasksList;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.Lessons.LessonOne
{
    public class SolvingTheTask_1_2
    {
            /*
             Zad. 2. Utwórz dwie zmienne liczbowe i przypisz im wartości. 
            Wyświetl w konsoli wyniki 
            dodawania, odejmowania, mnożenia oraz dzielenia. 
            Niech druga liczba nie będzie zerem. 
            Użyj typu danych double.
            */

        public void Solving_1_2()
        {
            double firstValue = 5.25;
            double secondValue = 6.78;
            double sum = firstValue + secondValue;
            double subtraction = firstValue - secondValue;
            double multiplication = firstValue * secondValue;
            double division = firstValue / secondValue;

            Console.Clear();
            Console.WriteLine(  "Lekcja nr 1; Zadanie nr 2");
            ListOfTasksForLessonOne listOfTasksForLessonOne = new ListOfTasksForLessonOne();
            Console.WriteLine(listOfTasksForLessonOne.PrintLessonOneTasks(2));

            Console.WriteLine("pierwszy sposób prezentacji");
            Console.WriteLine($"{firstValue} + {secondValue} = {sum}");
            Console.WriteLine($"{firstValue} - {secondValue} = {subtraction}");
            Console.WriteLine($"{firstValue} * {secondValue} = {multiplication}");
            Console.WriteLine($"{firstValue} / {secondValue} = {division}");
            Console.WriteLine();
            Console.WriteLine("dodawanie: " + firstValue + " + " + secondValue + " = " + sum);
            Console.WriteLine("odejmowanie: " + firstValue + " - " + secondValue + " = " + subtraction);
            Console.WriteLine("mnożenie: " + firstValue + " * " + secondValue + " = " + multiplication);
            Console.WriteLine("dzielenie: " + firstValue + " / " + secondValue + " = " + division);
            Console.ReadKey();
        }
    }
}
