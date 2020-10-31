using First.TasksList;
using System;
using System.Collections.Generic;
using System.Text;

namespace First.Lessons.LessonThree
{
    class SolvingTheTask_3_1
    {
        /*
        * Napisz kalkulator, w którym użytkownik poda dwie liczby, 
        * a następnie wybierze działanie, które chce wykonać 
        * (1. Dodawanie, 2. Odejmowanie, 3. Mnożenie, 4. Dzielenie) i otrzyma w konsoli gotowy wynik. 
        * Przy konstruowaniu logiki menu wyboru działania zastosuj konstrukcję if…else, 
        * którą zagęścisz (warunek w warunku). 
        * Pamiętaj cholero, nie dziel przez 0! 
        * Co, jeśli użytkownik poda działanie nieprawidłowo?
        */
        public void Solving_3_1()
        {

            Console.Clear();
            Console.WriteLine("Lekcja nr 3, zadanie nr 1");
            Console.WriteLine("");

            ListOfTasksForLessonThree listOfTasksForLessonThree = new ListOfTasksForLessonThree();
            Console.WriteLine(listOfTasksForLessonThree.PrintLessonThreeTasks(1));

            double firstValue;
            double secondValue;
            string auxiliaryValue;
            string menuValue;

            Console.WriteLine("Kalkulator - sam wybierz jakie działanie ma być wykonane");
            Console.WriteLine("Podaj pierwszą wartość");
            auxiliaryValue = Console.ReadLine();
            firstValue = double.Parse(auxiliaryValue);
            Console.WriteLine("Podaj drugą wartość");
            auxiliaryValue = Console.ReadLine();
            secondValue = double.Parse(auxiliaryValue);
            Console.WriteLine("Wciśnij 1 aby rozpocząć.");
            Console.WriteLine("Wciśnij 0 aby zakończyć.");
            menuValue = Console.ReadLine();

            if (menuValue == "1")
            {
                while (menuValue == "1")
                {
                    string miniMenuValue;
                    Console.WriteLine("1. Dodawanie.");
                    Console.WriteLine("2. Odejmowanie.");
                    Console.WriteLine("3. Mnożenie.");
                    Console.WriteLine("4. Dzielenie.");
                    Console.WriteLine("0. Wyjdź z kalkulatora.");
                    miniMenuValue = Console.ReadLine();

                    if (miniMenuValue == "1")
                    {
                        Console.WriteLine("Wybrano dodawanie.");
                        Console.WriteLine(firstValue + " + " + secondValue + " = " + (firstValue + secondValue));
                    }
                    if (miniMenuValue == "2")
                    {
                        Console.WriteLine("Wybrano odejmowanie.");
                        Console.WriteLine(firstValue + " - " + secondValue + " = " + (firstValue - secondValue));
                    }
                    if (miniMenuValue == "3")
                    {
                        Console.WriteLine("Wybrano mnożenie.");
                        Console.WriteLine(firstValue + " * " + secondValue + " = " + (firstValue * secondValue));
                    }
                    if (miniMenuValue == "4")
                    {
                        Console.WriteLine("Wybrano dzielenie.");
                        if (secondValue != 0)
                        {
                            Console.WriteLine(firstValue + " / " + secondValue + " = " + (firstValue / secondValue));
                        }
                        else if (secondValue == 0)
                        {
                            Console.WriteLine("Nie dziel cholero przez zero !!!");
                            Console.WriteLine("Wprowadź wartość drugiel liczby ponownie - inna niż zero.");
                        }
                    }
                    if (miniMenuValue == "0")
                    {
                        Console.WriteLine("Wyjście");
                        return;
                    }
                }
                if (menuValue == "0")
                {
                    return;
                }
            }
            Console.ReadKey();
        }
    }
}
