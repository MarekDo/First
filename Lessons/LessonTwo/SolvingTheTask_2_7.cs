using First.TasksList;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.Lessons.LessonTwo
{
    class SolvingTheTask_2_7
    {
             /*
             * Napisz program konsolowy, który pobierze z konsoli długości trzech boków trójkąta.
             * Sprawdź, czy z podanych wartości można utworzyć trójkąt. Wypisz wynik w konsoli.
             */

        public void Solving_2_7()
        {
            Console.Clear();
            Console.WriteLine("Lekcja nr 2, zadanie nr 7");
            Console.WriteLine("");

            ListOfTasksForLessonTwo listOfTasksForLessonTwo = new ListOfTasksForLessonTwo();
            Console.WriteLine(listOfTasksForLessonTwo.PrintLessonTwoTasks(7));

            double firstSide;
            double secondSide;
            double thirdSide;

            Console.WriteLine("Podaj długości trzech boków trójkąta.");
            Console.WriteLine("wartości muszą być większe od zera");

            Console.WriteLine("Wpisz długość pierwszego boku:");
            firstSide = EnterSideValue();

            Console.WriteLine("Wpisz długość drugiego boku:");
            secondSide = EnterSideValue();

            Console.WriteLine("Wpisz długość trzeciego boku:");
            thirdSide = EnterSideValue();

            if ((firstSide + secondSide > thirdSide)
                && (secondSide + thirdSide > firstSide)
                && (firstSide + thirdSide > secondSide))
            {
                Console.WriteLine("Z podanych wartości można utworzyć trójkąt");
            }
            else
            {
                Console.WriteLine("Przykro mi z podanych wartości nie mozna utworzyć trójkąta.");
            }

            Console.ReadKey();
        }

        private double EnterSideValue()
        {
            string auxiliaryValue = Console.ReadLine();
            double side = double.Parse(auxiliaryValue);

            while (side <= 0)
            {
                Console.WriteLine("wprowadziłeś wartość mniejszą lub równą zero");
                Console.WriteLine("Wprowadź jeszcze raz poprawną wartość większą od zera !!!");
                auxiliaryValue = Console.ReadLine();
                side = double.Parse(auxiliaryValue);
            }
            return side;
        }
    }
}
