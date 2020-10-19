﻿
using First.Lessons.LessonOne;
using First.Menus;
using First.TasksList;
using Microsoft.Win32.SafeHandles;
using System;
using System.ComponentModel.Design.Serialization;
using System.Dynamic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {

            LessonOfService();
        }

        static void LessonOfService()
        {
            Console.Clear();
            MainMenu mainMenu = new MainMenu();
            mainMenu.PrintOnScreenMainMenu();

            string option = Console.ReadLine();

            if (option == "1")
            {
                LessonNumber_1();
            }
            else if (option == "2")
            {
                LessonNumber_2();
            }
            else if (option == "3")
            {
                LessonNumber_3();
            }
            else if (option == "4")
            {
                LessonNumber_4();
            }
            else if (option == "15")
            {
                Console.Clear();
                Console.WriteLine("Dziękuję za udział i do zobaczenia:");
                return;
            }
        }

        static void MenuOfLessonNr1()
        {
            MenuOfLessonOne menuOfLessonOne = new MenuOfLessonOne();
            menuOfLessonOne.PrintOnScreenMainMenu();
        }

        static void MenuOfLesson2()
        {
            MenuOfLessonTwo menuOfLessonTwo = new MenuOfLessonTwo();
            menuOfLessonTwo.PrintOnScreenMainMenu();
        }

        static void MenuOfLesson3()
        {
            MenuOfLessonThree menuOfLessonThree = new MenuOfLessonThree();
            menuOfLessonThree.PrintOnScreenMainMenu();
        }

        static void MenuOfLesson4()
        {
            MenuOfLessonFour menuOfLessonFour = new MenuOfLessonFour();
            menuOfLessonFour.PrintOnScreenMainMenu();
        }

        static void LessonNumber_1()
        {
            Console.WriteLine("Wybrales lekcje nr 1");
            Console.WriteLine("Wciśnij dowolny klawisz ...");
            string option = "-1";

            while (option != "0")
            {
                MenuOfLessonNr1();
                option = Console.ReadLine();

                if (option == "1")
                {
                    SolvingTheTask_1_1 solvingTheTask_1_1 = new SolvingTheTask_1_1();
                    solvingTheTask_1_1.Solving_1_1();
                }
                else if (option == "2")
                {
                    Console.Clear();
                    Lesson1Part2();
                    Console.WriteLine("Wciśnij dowolny klawisz ...");
                    Console.ReadKey();

                }
                else if (option == "3")
                {
                    Console.Clear();
                    Lesson1Part3();
                    Console.WriteLine("Wciśnij dowolny klawisz ...");
                    Console.ReadKey();

                }
                else if (option == "4")
                {
                    Console.Clear();
                    Lesson1Part4();
                    Console.WriteLine("Wciśnij dowolny klawisz ...");
                    Console.ReadKey();

                }
                else if (option == "5")
                {
                    ListOfTasksForLessonOne listOfTasksForLessonOne = new ListOfTasksForLessonOne();
                    listOfTasksForLessonOne.PrintLessonOneTasks();
                }

            }
            LessonOfService();
        }


        static void LessonNumber_2()
        {
            Console.WriteLine("Wybrales lekcje nr 2");
            Console.WriteLine("Press any key...");
            string option = Console.ReadLine();

            while (option != "0")
            {
                MenuOfLesson2();
                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.Clear();
                    Lesson2Part1();
                    Console.ReadKey();
                }
                else if (option == "2")
                {
                    Console.Clear();
                    Lesson2Part2();
                    Console.ReadKey();
                }
                else if (option == "3")
                {
                    Console.Clear();
                    Lesson2Part3();
                    Console.ReadKey();
                }
                else if (option == "4")
                {
                    Console.Clear();
                    Lesson2Part4();
                    Console.ReadKey();
                }
                else if (option == "5")
                {
                    Console.Clear();
                    Lesson2Part5();
                    Console.ReadKey();
                }
                else if (option == "6")
                {
                    Console.Clear();
                    Lesson2Part6();
                    Console.ReadKey();
                }
                else if (option == "7")
                {
                    Console.Clear();
                    Lesson2Part7();
                    Console.ReadKey();
                }
                else if (option == "8")
                {
                    Console.Clear();
                    Lesson2Part8();
                    Console.ReadKey();
                }

                else if (option == "9")
                {
                    ListOfTasksForLessonTwo listOfTasksForLessonTwo = new ListOfTasksForLessonTwo();
                    listOfTasksForLessonTwo.PrintLessonTwoTasks();
                    
                }
            }
            LessonOfService();
        }

        static void LessonNumber_3()
        {
            Console.WriteLine("Wybrales lekcje nr 3");
            Console.WriteLine("naciśnij dowolny klawisz ...");
            string option = Console.ReadLine();

            while (option != "0")
            {
                MenuOfLesson3();
                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.Clear();
                    Lesson3Part1();
                    Console.ReadKey();
                }
                else if (option == "2")
                {
                    Console.Clear();
                    Lesson3Part2();
                    Console.ReadKey();
                }
                else if (option == "3")
                {
                    Console.Clear();
                    Lesson3Part3();
                    Console.ReadKey();
                }
                else if (option == "4")
                {
                    Console.Clear();
                    Lesson3Part4();
                    Console.ReadKey();
                }
                else if (option == "5")
                {
                    Console.Clear();
                    Lesson3Part5();
                    Console.ReadKey();
                }
                else if (option == "6")
                {
                    Console.Clear();
                    Lesson3Part6();
                    Console.ReadKey();
                }
                else if (option == "7")
                {
                    Console.Clear();
                    Lesson3Part7();
                    Console.ReadKey();
                }
                else if (option == "8")
                {
                    Console.Clear();
                    Lesson3Part8();
                    Console.ReadKey();
                }

                else if (option == "9")
                {
                    ListOfTasksForLessonThree listOfTasksForLessonThree = new ListOfTasksForLessonThree();
                    listOfTasksForLessonThree.PrintLessonThreeTasks();
                }
            }
            LessonOfService();
        }

        static void LessonNumber_4()
        {
            Console.WriteLine("Wybrales lekcje nr 4");
           
            string option = Console.ReadLine();

            while (option != "0")
            {
                MenuOfLesson4();
                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.Clear();
                    Lesson4Part1();
                    Console.ReadKey();
                }
                else if (option == "2")
                {
                    Console.Clear();
                    Lesson4Part2();
                    Console.ReadKey();
                }
                else if (option == "3")
                {
                    Console.Clear();
                    Lesson4Part3();
                    Console.ReadKey();
                }
                else if (option == "4")
                {
                    Console.Clear();
                    Lesson4Part4();
                    Console.ReadKey();
                }
                else if (option == "5")
                {
                    Console.Clear();
                    Lesson4Part5();
                    Console.ReadKey();
                }
                else if (option == "6")
                {
                    Console.Clear();
                    Lesson4Part6();
                    Console.ReadKey();
                }
                else if (option == "7")
                {
                    Console.Clear();
                    Lesson4Part7();
                    Console.ReadKey();
                }
                else if (option == "8")
                {
                    Console.Clear();
                    Lesson4Part8();
                    Console.ReadKey();
                }
                else if (option == "9")
                {
                    Console.Clear();
                    Lesson4Part9();
                    Console.ReadKey();
                }
                else if (option == "10")
                {
                    Console.Clear();
                    Lesson4Part10();
                    Console.ReadKey();
                }
                else if (option == "11")
                {
                    Console.Clear();
                    Lesson4Part11();
                    Console.ReadKey();
                }
                else if (option == "12")
                {
                    Console.Clear();
                    Lesson4Part12();
                    Console.ReadKey();
                }
                else if (option == "13")
                {
                    Console.Clear();
                    Lesson4Part13();
                    Console.ReadKey();
                }
                else if (option == "14")
                {
                    Console.Clear();
                    Lesson4Part14();
                    Console.ReadKey();
                }
                else if (option == "15")
                {
                    Console.Clear();
                    Lesson4Part15();
                    Console.ReadKey();
                }
                else if (option == "16")
                {
                    Console.Clear();
                    Lesson4Part16();
                    Console.ReadKey();
                }
                else if (option == "17")
                {
                    Console.Clear();
                    Lesson4Part17();
                    Console.ReadKey();
                }
                else if (option == "18")
                {
                    Console.Clear();
                    Lesson4Part18();
                    Console.ReadKey();
                }

                else if (option == "19")
                {
                    ListOfTasksForLessonFour listOfTasksForLessonFour = new ListOfTasksForLessonFour();
                    listOfTasksForLessonFour.PrintLessonFourTasks();
                }
            }
            LessonOfService();
        }

        static void Lesson1Part1()
        {
            Console.WriteLine("Zadanie nr 1");
            /*
             * Wypisz w konsoli swoje imię i nazwisko, wykorzystując
             * w tym celu wszystkie znane Ci metody wyświetlania komunikatów.
            */

            EnterUser enterUser = new EnterUser();
            enterUser.EnterName();
            enterUser.PrintDateOfUser();
            Console.ReadKey();
        }

        static void Lesson1Part2()
        {

            Console.WriteLine("\n Zadanie nr 2");
            /*
             Zad. 2. Utwórz dwie zmienne liczbowe i przypisz im wartości. 
            Wyświetl w konsoli wyniki 
            dodawania, odejmowania, mnożenia oraz dzielenia. 
            Niech druga liczba nie będzie zerem. 
            Użyj typu danych double.
            */

            double firstValue = 5.25;
            double secondValue = 6.78;
            double sum = firstValue + secondValue;
            double subtraction = firstValue - secondValue;
            double multiplication = firstValue * secondValue;
            double division = firstValue / secondValue;

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
        }

        static void Lesson1Part3()
        {

            Console.WriteLine("\n Zadanie nr 3");
            /*
             * Utwórz dwie zmienne liczbowe i przypisz im wartości podane poprzez konsolę. 
             * Wyświetl w konsoli wyniki 
             * dodawania, odejmowania, mnożenia oraz dzielenia. 
             * Niech druga liczba nie będzie zerem. 
             * Użyj typu danych double.
             */

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

        }

        static void Lesson1Part4()
        {


            Console.WriteLine("\n Zadanie nr 4");
            /*
             * Utwórz dwie zmienne liczbowe typu double. 
             * Dla każdego z działań 
             * (dodawanie, odejmowanie, mnożenie i dzielenie) 
             * przypisz z konsoli nowy zestaw liczb 
             * oraz wypisz ich wyniki w konsoli w formie pełnych działań arytmetycznych ($”{}”).
             */

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
        }

        static void Lesson2Part1()
        {
            int firstValue = 45;
            int secondValue = 80;

            /*
             * Napisz program konsolowy, który spróbuje porównać ze sobą dwie zmienne typu int,
             * które zostaną zadeklarowane w kodzie programu. Zwróć uwagę na zachowanie programu
             * i wyświetlone komunikaty.
            */

            if (firstValue == secondValue)
            {
                Console.WriteLine(firstValue + " równe " + secondValue);
            }
            else if (firstValue < secondValue)
            {
                Console.WriteLine(firstValue + " jest mniejsze od " + secondValue);
            }
            else
                Console.WriteLine(firstValue + " jest większe " + secondValue);

            Console.ReadKey();

        }

        static void Lesson2Part2()
        {
            /*
             * Napisz program konsolowy, który porówna ze sobą dwie zmienne typu int ze zdefiniowanymi wartościami, 
             * które będą przez Ciebie podane w kodzie. Wypisz wynik porównania w konsoli.
             */

            int firstValue;
            int secondValue;

            firstValue = 800;
            secondValue = 600;

            if (firstValue == secondValue)
            {
                Console.WriteLine(firstValue + " = " + secondValue);
            }
            else if (firstValue < secondValue)
            {
                Console.WriteLine(firstValue + " jest mniejsze od " + secondValue);
            }
            Console.WriteLine(firstValue + " jest większe od " + secondValue);
            Console.WriteLine("Wciśnij dowolny klawisz ...");
            Console.ReadKey();
        }

        static void Lesson2Part3()
        {
            /*
             * Napisz program konsolowy, który porówna ze sobą dwie zmienne typu int, 
             * których wartości zostaną pobrane z konsoli. 
             * Wypisz wynik porównania w konsoli.
             */

            int firstValue;
            int secondValue;
            string stringValue;

            Console.WriteLine("Wprowadź dwie liczby całkowite ");
            Console.WriteLine("Wprowadź pierwszą liczbę: ");
            stringValue = Console.ReadLine();
            firstValue = int.Parse(stringValue);
            Console.WriteLine("Wskazana wartość do porównania to: " + firstValue);
            Console.WriteLine("Podaj drugą liczbę: ");
            stringValue = Console.ReadLine();
            secondValue = int.Parse(stringValue);
            Console.WriteLine("Druga liczba do porównania to: " + secondValue);
            Console.WriteLine("porównanie ...");

            if (firstValue == secondValue)
            {
                Console.WriteLine(firstValue + " i " + secondValue + "są takie same");
            }
            else if (firstValue < secondValue)
            {
                Console.WriteLine(firstValue + " jest mniejsze od " + secondValue);
            }
            else if (firstValue > secondValue)
                Console.WriteLine(firstValue + " jest większe od " + secondValue);

            Console.WriteLine("Wcosnij dowolny klawisz ...");
            Console.ReadKey();

        }

        static void Lesson2Part4()
        {
            /*
             * Napisz program konsolowy, który sprawdzi, 
             * czy wartość pobrana z konsoli jest 
             * większa od 5 i mniejsza od 20. Wypisz wynik w konsoli.
             */

            int firstValue = 5;
            int secondValue = 20;
            int movingVariable;
            string stringMovingVariable;

            Console.WriteLine("Wprowadź wartość do porównania:");
            stringMovingVariable = Console.ReadLine();
            movingVariable = int.Parse(stringMovingVariable);

            if (movingVariable > firstValue && movingVariable < secondValue)
            {
                Console.WriteLine("podana wartość jest z przedziału pomiędzy 5 a 20");
            }
            else
            {
                Console.WriteLine("Podana wartość jest spoza zakresu 5 a 20");
            }
        }

        static void Lesson2Part5()
        {
            Lesson2Part4();
        }

        static void Lesson2Part6()
        {
            /*
             * Napisz program konsolowy, który pobierze z konsoli dwie liczby całkowite, 
             * po czym do trzeciej zmiennej przypisze większą wartość. 
             * Wykorzystaj przypisanie warunkowe i wypisz wynik w konsoli.
             */
            int firstValue;
            int secondValue;
            int greaterValue;
            string movingValue;

            Console.WriteLine("Podaj pierwszą liczbę:");
            movingValue = Console.ReadLine();
            firstValue = int.Parse(movingValue);
            Console.WriteLine("Wprowadź drugą wartość:");
            movingValue = Console.ReadLine();
            secondValue = int.Parse(movingValue);

            if (firstValue == secondValue)
            {
                Console.WriteLine("obie rartości są takie same");
                greaterValue = firstValue;
            }
            else if (firstValue < secondValue)
            {
                greaterValue = secondValue;
                Console.WriteLine("Wieksza wartośc to: " + greaterValue);
            }
            else
            {
                greaterValue = firstValue;
                Console.WriteLine("Większa wartość to: " + greaterValue);
            }

        }

        static void Lesson2Part7()
        {
            /*
             * Napisz program konsolowy, który pobierze z konsoli długości trzech boków trójkąta.
             * Sprawdź, czy z podanych wartości można utworzyć trójkąt. Wypisz wynik w konsoli.
             */

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

        }

        static void Lesson2Part8()
        {
            /*
             * Napisz program konsolowy, który pobierze dwie wartości z konsoli. 
             * Wyświetl w konsoli wyniki dodawania, odejmowania, mnożenia oraz dzielenia. 
             * Pamiętaj, żeby przy próbie dzielenia przez 0 wyświetlić odpowiedni komunikat, 
             * który uniemożliwi przeprowadzenie „zakazanego” działania. 
             * Użyj typu danych double.
             */

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

        }

        static void Lesson3Part1()
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

            if (menuValue == "1") {
                while (menuValue == "1")
                {
                    string miniMenuValue;
                    Console.WriteLine("1. Dodawanie.");
                    Console.WriteLine("2. Odejmowanie.");
                    Console.WriteLine("3. Mnożenie.");
                    Console.WriteLine("4. Mnożenie.");
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

        }

        static void Lesson3Part2()
        {
            /*
             * Wykonaj Zad. 1. modyfikując strukturę if…else na if…else if…else. Dostrzegasz różnicę?
             */
        }

        static void Lesson3Part3()
        {
            /*
             * Wykonaj Zad. 1. wykorzystując tym razem blok switch…case. 
             * Która wersja programu Twoim zdaniem jest czytelniejsza?
             */


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
        }

        static void Lesson3Part4()
        {
            /*
             * Utwórz 4 metody: 
             * dodawanie (Addition), 
             * odejmowanie (Substraction), 
             * mnożenie (Multiplication), 
             * dzielenie (Division). 
             * Wykorzystaj je w kalkulatorze, z Zad. 2. bądź Zad. 3., 
             * którego zapis jest Twoim zdaniem czytelniejszy. 
             * Jak bardzo skrócił się kod Twojego programu?
             */
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
            double firstValue = EnterValue34();
            Console.WriteLine("Wprowadź drugą liczbę:");
            double secondValue = EnterValue34();

            Console.WriteLine("Wprowadź działanie: 1 - dodawanie; 2 - odejmowanie; 3 - odejmowanie; 4 - dzielenie");
            int menuValue = int.Parse(Console.ReadLine());

            switch (menuValue)
            {
                case 1:
                    Console.WriteLine("Dodawanie: " + firstValue + " + " + secondValue + " = " + (Addition34(firstValue, secondValue)));
                    break;
                case 2:
                    Console.WriteLine("Dodawanie: " + firstValue + " - " + secondValue + " = " + (Substraction34(firstValue, secondValue)));
                    break;
                case 3:
                    Multiplication34(firstValue, secondValue);
                    break;
                case 4:
                    Division34(firstValue, secondValue);
                    break;
                default:
                    Console.WriteLine("");
                    break;
            }
        }

        static void Lesson3Part5()
        {
            /*
             * Utwórz jeszcze 3 metody: dzielenie z resztą, 
             * druga potęga, trzecia potęga (nazewnictwo wedle uznania). 
             * Dodaj je do swojego kalkulatora.
             */
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
            double firstValue = EnterValue34();
            Console.WriteLine("Wprowadź drugą liczbę:");
            double secondValue = EnterValue34();

            Console.WriteLine("Wprowadź działanie: \n 1 - dodawanie; \n 2 - odejmowanie; " +
                "\n 3 - odejmowanie; \n 4 - dzielenie; \n 5 - dzielenie z resztą; \n 6 - potęgowanie kwadratowe; \n " +
                "7 - trzecia potęga; \n 8 - dowolna potęga;");

            int menuValue = int.Parse(Console.ReadLine());

            switch (menuValue)
            {
                case 1:
                    Console.WriteLine("Dodawanie: " + firstValue + " + " + secondValue + " = " + (Addition34(firstValue, secondValue)));
                    break;
                case 2:
                    Console.WriteLine("Dodawanie: " + firstValue + " - " + secondValue + " = " + (Substraction34(firstValue, secondValue)));
                    break;
                case 3:
                    Multiplication34(firstValue, secondValue);
                    break;
                case 4:
                    Division34(firstValue, secondValue);
                    break;
                case 5:
                    Modulo35(firstValue, secondValue);
                    break;
                case 6:
                    Squared35(firstValue);
                    break;
                case 7:
                    Cubed35(firstValue);
                    break;
                case 8:
                    ToThePower35(firstValue, secondValue);
                    break;
                default:
                    Console.WriteLine("");
                    break;
            }
        }

        static void Lesson3Part6()
        {
            /*
             * Na rozluźnienie szarych komórek, dodaj do swojego kalkulatora możliwość rezygnacji z obliczeń 
             */

            Console.WriteLine("Opracować rezygnację z obliczeń");
        }

        static void Lesson3Part7()
        {
            /*
             * Napisz program, który będzie wypisywał pierwiastki równania kwadratowego o postaci
             * ax2 + bx + c = 0.
             * niech użytkownik poda wartości liczb a, b i c
             * sprawdź, czy są pierwiastki, czy są jeden, czy dwa
             * wypisz rozwiązania równania kwadratowego w konsoli, 
             * a jeśli takowych brak - stosowny komunikat.
            */
            Console.WriteLine("Program do oblicznia pierwiastków równania kwadratowego.");
            Console.WriteLine("ax2 + bx + c = 0");
            Console.WriteLine("Wrpowadzasz wartości dla a: b: i c:");
            Console.WriteLine("Wprowadź wartość a:");
            double valueA = double.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadź wartość b:");
            double valueB = double.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadź wartość c:");
            double valueC = double.Parse(Console.ReadLine());

            Delta(valueA, valueB, valueC);
        }

        static void Lesson3Part8()
        {
            /*
             * Napisz program, który będzie liczył pole i obwód figury. 
             * Rozwiązując zadanie daj: menu wyboru figury,
             * możliwość podania długości boków, 
             * podstaw, 
             * promienia bądź wysokości w zależności od figury 
             * wypisz wyniki w konsoli.
             * Napisz algorytmy dla: kwadratu, prostokąta, trójkąta, trapezu, koła, rombu i równoległoboku.
             */

            Console.WriteLine("Obliczanie pól i obwodów figur geometrycznych");
            Console.WriteLine("1. Rozpoczęcie. \n 2. Zakończ");
            int startStop = int.Parse(Console.ReadLine());

            while (startStop == 1)
            {
                Console.Clear();
                Console.WriteLine("Wprowadź figurę goemetryczną dla której będą obliczenia:" +
                    "\n 1 - Kwadrat." +
                    "\n 2 - Prostokąt." +
                    "\n 3 - Trójkąt." +
                    "\n 4 - Trapez." +
                    "\n 5 - Koło." +
                    "\n 6 - Romb." +
                    "\n 7 - Równoległobok" +
                    "\n 8 - Zakończ");

                int lokalMenu = int.Parse(Console.ReadLine());

                switch (lokalMenu)
                {
                    case 1:
                        Square38();
                        break;
                    case 2:
                        rectangle38();
                        break;
                    case 3:
                        triangle38();
                        break;
                    case 4:
                        trapeze38();
                        break;
                    case 5:
                        Console.WriteLine("Koło");

                        break;
                    case 6:
                        Console.WriteLine("Romb");

                        break;
                    case 7:
                        Console.WriteLine("Równoległobok");

                        break;
                    case 8:
                        return;
                    default:
                        break;


                }

            }


        }

        static void Lesson4Part1()
        {
            /*
             * Napisz program, który wypisze liczby od 0 do podanej przez użytkownika. 
             * Pamiętaj o zachowaniu odpowiednich odstępów pomiędzy poszczególnymi liczbami.
             */

            Console.WriteLine("Podaj wartość do któej ma zliczać - większą od zera");
            int value = int.Parse(Console.ReadLine());
            if (value > 0)
            {
                for (int i = 0; i <= value; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else {
                Console.WriteLine("Podana wartość jest mniejsza od 0 lub równa, spróbuj jeszcze raz.");
            }

        }

        static void Lesson4Part2()
        {
            /*
             * Zmodyfikuj poprzedni program tak, żeby tym razem użytkownik mógł wybrać także liczbę początkową. 
             * Zwróć uwagę, czy wypisane są także liczby graniczne.
             */
            Console.WriteLine("Podaj wartość od któtrej ma być zliczanie: ");
            int startValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartość do któtrej ma być zliczanie: ");
            int stopValue = int.Parse(Console.ReadLine());

            if (startValue < stopValue)
            {
                for (int i = startValue; i <= stopValue; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Nie mozna wykonac operacji, pierwsza wartośc jest większa lub równa od drugiej.");
            }
        }

        static void Lesson4Part3()
        {
            /*
             * Zmodyfikuj program z zad. 1. tak, żeby zamiast wypisywać liczby od 0, 
             * zaczął odliczać od liczby podanej przez użytkownika do zera.
             */

            Console.WriteLine("Podaj wartość od której ma zliczać do 0");
            int value = int.Parse(Console.ReadLine());

            if (value > 0)
            {
                for (int i = value; i >= 0; i--)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Wprowadzona wartość jest mniejsza od zera lub równa zeru");
            }

        }

        static void Lesson4Part4()
        {
            /*
             * Przerób poprzedni program tak, żeby odliczał tylko w obrębie zakresu podanego jak w zad. 11.
             */

            Console.WriteLine("Podaj wartość od któtrej ma być zliczanie: ");
            int startValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartość do któtrej ma być zliczanie (mniejsza od pierwszej liczby): ");
            int stopValue = int.Parse(Console.ReadLine());

            if (startValue > stopValue)
            {
                for (int i = startValue; i >= stopValue; i--)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Nie mozna wykonac operacji, pierwsza wartośc jest mniejsza lub równa od drugiej.");
            }

        }

        static void Lesson4Part5()
        {
            /*
             * Napisz program, który w konsoli wypisze tabliczkę mnożenia liczb od 1 do 10.
             */

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("1 * " + i + " = " + (1 * i));
            }

        }

        static void Lesson4Part6()
        {
            /*
             * Napisz program, który będzie wypisywał w konsoli tabliczkę mnożenia liczb od 1 do liczby podanej przez użytkownika.
             */

            Console.WriteLine("Wypisanie tabliczki mnożenia od 1 do wartości podanej: ");
            Console.WriteLine("Wpisz liczbę całkowitą: ");
            int value = int.Parse(Console.ReadLine());

            for (int i = 1; i <= value; i++)
            {
                Console.WriteLine("1 * " + i + " = " + (1 * i));
            }
        }

        static void Lesson4Part7()
        {
            /*
             * Napisz program, który wypisze w konsoli tylko liczby parzyste z zakresu od 0 do 100.
             */
            Console.WriteLine("tylko liczby parzyste do 100 ");

            for (int i = 0; i <= 100; i++)
            {

                if ((i % 2) == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Lesson4Part8()
        {
            /*
             * Napisz program, który wypisze w konsoli tylko liczby nieparzyste z zakresu od 0 do 100.
             */

            Console.WriteLine("Liczby nieparzyste od 0 do 100");
            for (int i = 0; i <= 100; i++)
            {
                if ((i % 2) != 0)
                {
                    Console.WriteLine(i);
                }
            }

        }

        static void Lesson4Part9()
        {
            /*
             * Napisz program, w którym użytkownik będzie mógł wybrać, czy chce wypisać liczby parzyste, 
             * czy nieparzyste, z zakresu podanego przez użytkownika. 
             */
            Console.WriteLine("Programik do wypisywania liczb parzystych lub nieparzystych");
            Console.WriteLine("Wpisz: p jeśli chcesz liczby parzyste lub wpisz: n jeśli mają byc to nieparzyste");
            string value = Console.ReadLine();
            if (value == "n")
            {
                for (int i = 0; i <= 100; i++)
                {
                    if ((i % 2) != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else if (value == "p")
            {
                for (int i = 0; i <= 100; i++)
                {
                    if ((i % 2) == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Miałeś wcisnąć n lub p. Żle wybrałeś zaczynasz jeszcze raz");
            }


        }

        static void Lesson4Part10()
        {
            /*
             * Napisz program, który będzie wypisywał liczby podzielne przez 2, 3, 4, 5, 7, 9 z podanego zakresu. 
             * Pamiętaj, żeby oddzielić poszczególne działania.
             */

            Console.WriteLine("Wypisanie liczb podzielnych przez 2, 3, 4, 5, 7, 9 z podanego zakresu.");
            Console.WriteLine("Podaj pierwszą liczbę całkowitą zakresu:");
            int firstValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj ostatnia liczbę całkowitą zakresu:");
            int lastValue = int.Parse(Console.ReadLine());
            Console.WriteLine($"Zakres: od {firstValue} do {lastValue}");

            for (int i = firstValue; i <= lastValue; i++)
            {

                if ((i % 2) == 0)
                {
                    Console.WriteLine(i + " jest podzilene przez 2");
                }
                if ((i % 3) == 0)
                {
                    Console.WriteLine(i + " jest podzilene przez 3");
                }
                if ((i % 4) == 0)
                {
                    Console.WriteLine(i + " jest podzilene przez 4");
                }
                if ((i % 5) == 0)
                {
                    Console.WriteLine(i + " jest podzilene przez 5");
                }
                if ((i % 7) == 0)
                {
                    Console.WriteLine(i + " jest podzilene przez 7");
                }
                if ((i % 9) == 0)
                {
                    Console.WriteLine(i + " jest podzilene przez 9");
                }


            }
        }

        static void Lesson4Part11()
        {
            /*
             * Zmodyfikuj poprzedni program tak, żeby użytkownik mógł wybrać, który dzielnik chce wybrać.
             */
            Console.WriteLine("Wypisanie liczb podzielnych przez 2, 3, 4, 5, 7, 9 z podanego zakresu.");
            Console.WriteLine("Wpisz podzielnik 2 lub 3 lub 4 lub 5 lub 7 lub 9 dla niżej wskazanego przez siebie zakresu");
            int divisor = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj pierwszą liczbę całkowitą zakresu:");
            int firstValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj ostatnia liczbę całkowitą zakresu:");
            int lastValue = int.Parse(Console.ReadLine());
            Console.WriteLine($"Zakres: od {firstValue} do {lastValue}");

            for (int i = firstValue; i <= lastValue; i++)
            {

                if ((i % divisor) == 0)
                {
                    Console.WriteLine($"{i} jest podzilene przez {divisor}");
                }

            }
        }

        static void Lesson4Part12()
        {
            /*
             * Napisz program, który będzie wypisywał wszystkie liczby pierwsze z przedziału od 0 do liczby podanej przez użytkownika.
             */
            Console.WriteLine("Podaj liczbę większą od zero a podam Ci wszystkie liczby pierwsze");
            Console.WriteLine("Podaj ostatnia liczbę całkowitą zakresu:");
            int rangeOfNumbers = int.Parse(Console.ReadLine());
            int root = (int)Math.Sqrt(rangeOfNumbers);

        }

        static void Lesson4Part13()
        {
            /*
             * Zmodyfikuj poprzedni program tak, żeby użytkownik mógł podać zakres liczb.
             */


        }

        static void Lesson4Part14()
        {
            /*
             * Zmodyfikuj program Kalkulator tak, żeby po zakończeniu obliczeń pytał użytkownika, 
             * czy chce kontynuować obliczenia bez wychodzenia z programu. 
             * Użytkownik za każdym razem ma podawać liczby, na których chce działać i wybrać działanie.
             */
        }

        static void Lesson4Part15() {
            /*
             * Napisz program, który będzie w konsoli za pomocą gwiazdek (*) 
             * rysował kwadrat o długości boku podanej przez użytkownika (długość boku = ilość gwiazdek). 
             * Pamiętaj o dodaniu odpowiednich odstępów pomiędzy gwiazdkami.
             * */

            Console.WriteLine("Podaj długość boku");
            int lenghtSquare = int.Parse(Console.ReadLine());

            for (int i = 0; i < lenghtSquare; i++)
            {
                for (int j = 0; j < lenghtSquare; j++)
                {
                    if ((i == 0) || (i == lenghtSquare - 1))
                    {
                        Console.Write("* ");
                    }
                    else
                        if ((j == 0) || (j == lenghtSquare - 1))
                        {
                        Console.Write("* ");
                        }
                    else
                        Console.Write("  ");//wypełnienie środka kwadratu

                }
                Console.WriteLine();
            }

        }

        static void Lesson4Part16()
        {
            /*
             * Zmodyfikuj poprzedni program tak, żeby rysował prostokąt o podanej długości boków.
             */

            Console.WriteLine("Podaj wysokość prostokąta ");
            int heightOfTheRectangle = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj szerokość prostokąta ");
            int widthOfTheRectangle = int.Parse(Console.ReadLine());

            for (int i = 0; i < heightOfTheRectangle; i++)
            {
                for (int j = 0; j < widthOfTheRectangle; j++)
                {
                    if ((i == 0) || (i == heightOfTheRectangle - 1))
                    {
                        Console.Write("* ");
                    }
                    else
                        if ((j == 0) || (j == widthOfTheRectangle - 1))
                    {
                        Console.Write("* ");
                    }
                    else
                        Console.Write("  ");//wypełnienie środka prostokąta

                }
                Console.WriteLine();
            }

        }

        static void Lesson4Part17()
        {
            /*
             * Napisz program, który będzie rysował w konsoli za pomocą gwiazdek 
             * trójkąt prostokątny równoramienny o wysokości podanej przez użytkownika.
             */

            Console.WriteLine("Podaj wysokość trójkąta równoramiennego");
            int heightOfTheTriangle = int.Parse(Console.ReadLine());

            for(int i = 0; i <= heightOfTheTriangle; i++)
            {
                for(int j = 0; j <= heightOfTheTriangle; i++)
                {
                    Console.WriteLine("*");
                }
            }

        }

        static void Lesson4Part18()
        {
            //TODO
        }

        static void trapeze38()
         {
        //Zrobić metodę z sprawdzeniem czy można utworzyć trapez - sprawdzić czy z długośći się utworzy
         }

        static void triangle38()
        {
            Console.WriteLine("Obliczenia dla trójkata - znając długości jego boków:");
            Console.WriteLine("Podaj warość długości pierwszego boku:");
            double firstSide = double.Parse(Console.ReadLine());       
            Console.WriteLine("Podaj warość długości drugiego boku:");
            double secondSide = double.Parse(Console.ReadLine());     
            Console.WriteLine("Podaj warość długości trzeciego boku:");
            double thirdSide = double.Parse(Console.ReadLine());
            
            double perimeterOftheSquare = firstSide + secondSide + thirdSide;
            double halfPerimeterOftheSquare = perimeterOftheSquare / 2;
            double squareArea = Math.Sqrt(halfPerimeterOftheSquare * (halfPerimeterOftheSquare - firstSide)
                * (halfPerimeterOftheSquare - secondSide) * (halfPerimeterOftheSquare - thirdSide));
            Console.WriteLine($"Pole trójkąta wynosi: {squareArea}");
            Console.WriteLine($"Obwód trójkąta wynosi: {perimeterOftheSquare}");
            Console.ReadKey();
        }

        static void rectangle38()
        {
            Console.WriteLine("Obliczenia dla prostokąta");
            Console.WriteLine("Podaj warość długości dłuższego boku:");
            double longerSide = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj warość długości krutszego boku:");
            double shorterSide = double.Parse(Console.ReadLine());
            double squareArea = longerSide * shorterSide;
            double perimeterOftheSquare = (longerSide * 2) + (shorterSide * 2);
            Console.WriteLine($"Pole prostokąta wynosi: {squareArea}");
            Console.WriteLine($"Obwód prostokąta wynosi: {perimeterOftheSquare}");
            Console.ReadKey();
        }

        static void Square38()
        {
            Console.WriteLine("Obliczenia dla kwadratu");
            Console.WriteLine("Podaj warość długości boku:");
            double sideLength = double.Parse(Console.ReadLine());
            double squareArea = Math.Pow(sideLength, 2);
            double perimeterOftheSquare = sideLength * 4;
            Console.WriteLine($"Pole kwadratu wynosi: {squareArea}") ;
            Console.WriteLine($"Obwód kwadratu wynosi: {perimeterOftheSquare}");
            Console.ReadKey();
        }

        static void Delta(double valueA, double valueB, double valueC)
        {
           
            double deltaLocal = (Math.Pow(valueB, 2)) - (4 * valueA * valueC);

            if(deltaLocal < 0)
            {
                Console.WriteLine("Równanie nie ma pierwiastków.");
            }
            else if (deltaLocal == 0)
            {
                double lokalX = (-valueB) / (2 * valueA);
                Console.WriteLine("Występuje jeden pierwiastek: " + lokalX);              
            }
            else if(deltaLocal > 0)
            {
                double lokalA = (-valueB - (Math.Sqrt(deltaLocal))) / (2 * valueA);
                double lokalB = (-valueB + (Math.Sqrt(deltaLocal))) / (2 * valueA);
                Console.WriteLine("Występuja dwa pierwiaski: " + lokalA +" i " + lokalB);
            }
        }

        static void ToThePower35(double firstValue, double secondValue)
        {
            double result = Math.Pow(firstValue, secondValue);
            Console.WriteLine($" {firstValue} ^ {secondValue} = {result}");
        }

        static void Cubed35(double firstValue)
        {
            double result = Math.Pow(firstValue, 3);
            Console.WriteLine($" {firstValue} ^ {3} = {result}");
        }

        static void Squared35(double firstValue)
        {
            double result = Math.Pow(firstValue,2);
            Console.WriteLine($" {firstValue} ^ {2} = {result}");
        }

        static void Modulo35(double firstValue, double secondValue)
        {
            double result = firstValue % secondValue;
            Console.WriteLine("Wynik dzielenia z resztą: " +
                "\n" + firstValue + " % " + secondValue + " = " + result);
        }
    static void Division34(double firstValue, double secondValue)
    {
        if (secondValue != 0)
        {
            Console.WriteLine("2. Dzielenie: " + firstValue + " / " + secondValue + " = " + (firstValue / secondValue));
        }
        else
        {
            Console.WriteLine("Wprowadziłeś drugą wartość równą zero. A zasada mówi: nie dziel cholero przez zero");
        }
    }

    static void Multiplication34(double firstValue, double secondValue)
    {
        Console.WriteLine("2. Mnożenie: " + firstValue + " * " + secondValue + " = " + (firstValue * secondValue));
    }
    static double Substraction34(double firstValue, double secondValue)
    {
        return firstValue - secondValue;
    }

    static double Addition34(double firstValue, double secondValue)
    {
        return firstValue + secondValue;
    }

    static double EnterValue34()
    {
        double variableValue = double.Parse(Console.ReadLine());
        return variableValue;
    }
        
        static double EnterSideValue()
        {
        string auxiliaryValue = Console.ReadLine();
            double side = double.Parse(auxiliaryValue);

            while(side <= 0)
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
       
   

