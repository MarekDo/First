using First.TasksList;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.Lessons.LessonOne
{
    public class SolvingTheTask_1_4
    {

        /*
        * Utwórz dwie zmienne liczbowe typu double. 
        * Dla każdego z działań 
        * (dodawanie, odejmowanie, mnożenie i dzielenie) 
        * przypisz z konsoli nowy zestaw liczb 
        * oraz wypisz ich wyniki w konsoli w formie pełnych działań arytmetycznych ($”{}”).
        */
        public void Solving_1_4()
        {
            Console.Clear();
            Console.WriteLine("Lekcja nr 1; zadanie nr 4");
            ListOfTasksForLessonOne listOfTasksForLessonOne = new ListOfTasksForLessonOne();
            Console.WriteLine(listOfTasksForLessonOne.PrintLessonOneTasks(4));

            double firstValueFourthPart;
            double secondValueFourthPart;

            Console.WriteLine("Podaj pierwszą wartość dodawania: ");
            string valueFromConsoleFourthPart = Console.ReadLine();
            firstValueFourthPart = Double.Parse(valueFromConsoleFourthPart);
            Console.WriteLine("Podaj drugą wartość dodawania: ");
            valueFromConsoleFourthPart = Console.ReadLine();
            secondValueFourthPart = Double.Parse(valueFromConsoleFourthPart);

            Console.WriteLine($"Wynik dodawania: {firstValueFourthPart} + {secondValueFourthPart} " +
                $"= {firstValueFourthPart + secondValueFourthPart}");

            Console.WriteLine();
            Console.WriteLine("Podaj pierwszą wartość odejmowania: ");
            valueFromConsoleFourthPart = Console.ReadLine();
            firstValueFourthPart = Double.Parse(valueFromConsoleFourthPart);
            Console.WriteLine("Podaj drugą wartość odejmowania: ");
            valueFromConsoleFourthPart = Console.ReadLine();
            secondValueFourthPart = Double.Parse(valueFromConsoleFourthPart);

            Console.WriteLine($"Wynik odejmowania: {firstValueFourthPart} - {secondValueFourthPart} " +
                 $"= {firstValueFourthPart - secondValueFourthPart}");

            Console.WriteLine();
            Console.WriteLine("Podaj pierwszą wartość mnożenia: ");
            valueFromConsoleFourthPart = Console.ReadLine();
            firstValueFourthPart = Double.Parse(valueFromConsoleFourthPart);
            Console.WriteLine("Podaj drugą wartość mnożenia: ");
            valueFromConsoleFourthPart = Console.ReadLine();
            secondValueFourthPart = Double.Parse(valueFromConsoleFourthPart);

            Console.WriteLine($"Wynik mnożenia: {firstValueFourthPart} * {secondValueFourthPart} " +
                 $"= {firstValueFourthPart * secondValueFourthPart}");

            Console.WriteLine();
            Console.WriteLine("Podaj pierwszą wartość dzielenia: ");
            valueFromConsoleFourthPart = Console.ReadLine();
            firstValueFourthPart = Double.Parse(valueFromConsoleFourthPart);
            Console.WriteLine("Podaj drugą wartość dzielenia inną niż zero: ");
            valueFromConsoleFourthPart = Console.ReadLine();
            secondValueFourthPart = Double.Parse(valueFromConsoleFourthPart);
            while (secondValueFourthPart == 0)
            {
                Console.WriteLine("Miałeś podać wartość inną niż zero !!!!!!!!!!!!");
                Console.WriteLine("Jeszcze raz, skup się, to proste:");
                Console.WriteLine("Wpisz drugą liczbę inną niż zero: ");
                valueFromConsoleFourthPart = Console.ReadLine();
                secondValueFourthPart = Double.Parse(valueFromConsoleFourthPart);

            }
            Console.WriteLine("Ok, podana druga wartość jest poprawna ");


            Console.WriteLine($"Wynik dzielenia: {firstValueFourthPart} / {secondValueFourthPart} " +
                 $"= {firstValueFourthPart / secondValueFourthPart}");

            Console.ReadKey();
        }
    }
}
