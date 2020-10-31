using First.TasksList;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.Lessons.LessonTwo
{
    class SolvingTheTask_2_8
    {
           /*
           * Napisz program konsolowy, który pobierze dwie wartości z konsoli. 
           * Wyświetl w konsoli wyniki dodawania, odejmowania, mnożenia oraz dzielenia. 
           * Pamiętaj, żeby przy próbie dzielenia przez 0 wyświetlić odpowiedni komunikat, 
           * który uniemożliwi przeprowadzenie „zakazanego” działania. 
           * Użyj typu danych double.
           */

        public void Solving_2_8()
        {
            Console.Clear();
            Console.WriteLine("Lekcja nr 2, zadanie nr 8");
            Console.WriteLine("");

            ListOfTasksForLessonTwo listOfTasksForLessonTwo = new ListOfTasksForLessonTwo();
            Console.WriteLine(listOfTasksForLessonTwo.PrintLessonTwoTasks(8));

            double firstValue;
            double secondValue;
            string auxiliaryValue;

            Console.WriteLine("Wprowadź pierwszą wartość:");
            auxiliaryValue = Console.ReadLine();
            firstValue = double.Parse(auxiliaryValue);
            Console.WriteLine("Wprowadź drugą wartość:");
            auxiliaryValue = Console.ReadLine();
            secondValue = double.Parse(auxiliaryValue);

            Console.WriteLine("Wynik dodawania: " + firstValue + " + " + secondValue + " = " + (firstValue + secondValue));
            Console.WriteLine("Wynik odejmowania: " + firstValue + " - " + secondValue + " = " + (firstValue - secondValue));
            Console.WriteLine("Wynik mnożenia: " + firstValue + " * " + secondValue + " = " + (firstValue * secondValue));
            if (secondValue != 0)
            {
                Console.WriteLine("Wynik dzielenia: " + firstValue + " / " + secondValue + " = " + (firstValue / secondValue));
            }
            else
            {
                Console.WriteLine("Dzielenie niewykonalne gdyż chcesz dzielić przez zero!! ");
            }

            Console.ReadKey();
        }
    }
}
