using First.TasksList;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.Lessons.LessonThree
{
    class SolvingTheTask_3_3
    {
        /*
        * Wykonaj Zad. 1. wykorzystując tym razem blok switch…case. 
        * Która wersja programu Twoim zdaniem jest czytelniejsza?
        */

        public void Solving_3_3()
        {

            Console.Clear();
            Console.WriteLine("Lekcja nr 3, zadanie nr 3");
            Console.WriteLine("");

            ListOfTasksForLessonThree listOfTasksForLessonThree = new ListOfTasksForLessonThree();
            Console.WriteLine(listOfTasksForLessonThree.PrintLessonThreeTasks(3));

            string auxiliaryValue;


            Console.WriteLine("Kalkulator - sam wybierz działanie");
            Console.WriteLine("1. Rozpocznij");
            Console.WriteLine("2. Zakończ");
            auxiliaryValue = Console.ReadLine();
            if (auxiliaryValue != "1")
            {
                return;
            }


            Console.WriteLine("Wprowadź pierwszą liczbę:");
            double firstValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadź drugą liczbę:");
            double secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Wprowadź działanie: 1 - dodawanie; 2 - odejmowanie; 3 - odejmowanie; 4 - dzielenie");
            int menuValue = int.Parse(Console.ReadLine());

            switch (menuValue)
            {
                case 1:
                    Console.WriteLine("1. Dodawanie: " + firstValue + " + " + secondValue + " = " + (firstValue + secondValue));
                    break;
                case 2:
                    Console.WriteLine("2. Odejmowanie: " + firstValue + " - " + secondValue + " = " + (firstValue - secondValue));
                    break;
                case 3:
                    Console.WriteLine("2. Mnożenie: " + firstValue + " * " + secondValue + " = " + (firstValue * secondValue));
                    break;
                case 4:
                    if (secondValue != 0)
                    {
                        Console.WriteLine("2. Dzielenie: " + firstValue + " / " + secondValue + " = " + (firstValue / secondValue));
                    }
                    else
                    {
                        Console.WriteLine("Wprowadziłeś drugą wartość równą zero. A zasada mówi: nie dziel cholero przez zero");
                    }
                break;
                default:
                Console.WriteLine("");
                break;

            }   
         Console.ReadKey();

        }  
    }
}
