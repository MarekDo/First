using First.TasksList;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.Lessons.LessonOne
{
    public class SolvingTheTask_1_3
    {
        /*
 * Utwórz dwie zmienne liczbowe i przypisz im wartości podane poprzez konsolę. 
 * Wyświetl w konsoli wyniki 
 * dodawania, odejmowania, mnożenia oraz dzielenia. 
 * Niech druga liczba nie będzie zerem. 
 * Użyj typu danych double.
 */

        public void Solving_1_3()
        {
            Console.Clear();
            Console.WriteLine("Lekcja nr 1; zadanie nr 3");

            ListOfTasksForLessonOne listOfTasksForLessonOne = new ListOfTasksForLessonOne();
            Console.WriteLine(listOfTasksForLessonOne.PrintLessonOneTasks(3));

            double firstValueThirdPart;
            double secondValueThirdPart;

            Console.WriteLine("Wpisz pierwszą liczbę: ");
            string valueFromConsole = Console.ReadLine();
            firstValueThirdPart = Double.Parse(valueFromConsole);

            Console.WriteLine("Wpisz drugą liczbę inną niż zero: ");
            valueFromConsole = Console.ReadLine();
            secondValueThirdPart = Double.Parse(valueFromConsole);
            while (secondValueThirdPart == 0)
            {
                Console.WriteLine("Miałeś podać wartość inną niż zero !!!!!!!!!!!!");
                Console.WriteLine("Jeszcze raz, skup się, to proste:");
                Console.WriteLine("Wpisz drugą liczbę inną niż zero: ");
                valueFromConsole = Console.ReadLine();
                secondValueThirdPart = Double.Parse(valueFromConsole);

            }
            Console.WriteLine("Ok, podana druga wartość jest poprawna ");

            double sum = firstValueThirdPart + secondValueThirdPart;
            double subtraction = firstValueThirdPart - secondValueThirdPart;
            double multiplication = firstValueThirdPart * secondValueThirdPart;
            double division = firstValueThirdPart / secondValueThirdPart;


            Console.WriteLine($"{firstValueThirdPart} + {secondValueThirdPart} = {sum}");
            Console.WriteLine($"{firstValueThirdPart} - {secondValueThirdPart} = {subtraction}");
            Console.WriteLine($"{firstValueThirdPart} * {secondValueThirdPart} = {multiplication}");
            Console.WriteLine($"{firstValueThirdPart} / {secondValueThirdPart} = {division}");

            Console.WriteLine($"dodawanie: {firstValueThirdPart} + {secondValueThirdPart} = {firstValueThirdPart + secondValueThirdPart}");
            Console.WriteLine($"odejmowanie: {firstValueThirdPart} - {secondValueThirdPart} = {firstValueThirdPart - secondValueThirdPart}");
            Console.WriteLine($"mnożenie: {firstValueThirdPart} * {secondValueThirdPart} = {firstValueThirdPart * secondValueThirdPart}");
            Console.WriteLine($"dzielenie: {firstValueThirdPart} / {secondValueThirdPart} = {firstValueThirdPart / secondValueThirdPart}");
            Console.ReadKey();
        }

    }
}
