﻿using Microsoft.Win32.SafeHandles;
using System;
using System.Dynamic;
using System.Linq.Expressions;

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
            Console.WriteLine("Lekcje C#");
            Console.WriteLine("Podaj nr lekcji");
            Console.WriteLine("1. Zobacz zadania do lekcji nr 1.");
            Console.WriteLine("2. Zobacz zadania do lekcji nr 2.");
            Console.WriteLine("3. Zobacz zadania do lekcji nr 3.");
            Console.WriteLine("15. Zakończ program.");
            Console.WriteLine("Wprowadzony nr zatwierdź enterem");

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
            else if (option == "15")
            {
                Console.Clear();
                Console.WriteLine("Dziękuję za udział i do zobaczenia:");
                return;
            }
                


        }

        static void MenuOfLesson()
        {
            
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Rozwiązania zadań.");
            Console.WriteLine("2. Treści wszytskich zadań");
            Console.WriteLine("0. Wyjdź wyżej.");
            Console.WriteLine("Wprowadzony nr zatwierdź enterem");
        }

        static void MenuOfLessonNr1()
        {
            Console.Clear();
            Console.WriteLine("Lekcja 1");
            Console.WriteLine("1. Zadanie nr 1");
            Console.WriteLine("2. Zadanie nr 2");
            Console.WriteLine("3. Zadanie nr 3");
            Console.WriteLine("4. Zadanie nr 4");
            Console.WriteLine("0. Wyjście");
            Console.WriteLine("Wprowadzony nr zatwierdź enterem");
        }

        static void MenuOfLesson2()
        {
            Console.Clear();
            Console.WriteLine("Lekcja 2");
            Console.WriteLine("1. Zadanie nr 1");
            Console.WriteLine("2. Zadanie nr 2");
            Console.WriteLine("3. Zadanie nr 3");
            Console.WriteLine("4. Zadanie nr 4");
            Console.WriteLine("5. Zadanie nr 5");
            Console.WriteLine("6. Zadanie nr 6");
            Console.WriteLine("7. Zadanie nr 7");
            Console.WriteLine("8. Zadanie nr 8");
            Console.WriteLine("0. Wyjście");
            Console.WriteLine("Wprowadzony nr zatwierdź enterem");
        }

        static void MenuOfLesson3()
        {
            Console.Clear();
            Console.WriteLine("Lekcja 3");
            Console.WriteLine("1. Zadanie nr 1");
            Console.WriteLine("2. Zadanie nr 2");
            Console.WriteLine("3. Zadanie nr 3");
            Console.WriteLine("4. Zadanie nr 4");
            Console.WriteLine("5. Zadanie nr 5");
            Console.WriteLine("6. Zadanie nr 6");
            Console.WriteLine("7. Zadanie nr 7");
            Console.WriteLine("8. Zadanie nr 8");
            Console.WriteLine("0. Wyjście");
            Console.WriteLine("Wprowadzony nr zatwierdź enterem");
        }

        static void LessonNumber_1()
        {
            Console.WriteLine("Wybrales lekcje nr 1");
            MenuOfLesson();
            string option = Console.ReadLine();

            while (option != "0")
            { 
                MenuOfLessonNr1();
                option = Console.ReadLine();
            
                if (option == "1")
                {
                    Console.Clear();
                    Lesson1Part1();
                    Console.WriteLine("Wciśnij dowolny klawisz ...");
                    Console.ReadKey();

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
                    TaskContentLesson_1();

                }

            }
            LessonOfService();
        }
    

        static void LessonNumber_2()
        {
            Console.WriteLine("Wybrales lekcje nr 2");
            MenuOfLesson();
            string option = Console.ReadLine();

            while(option != "0")
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
                else if(option == "4")
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

                else if (option == "0")
                {
                    TaskContentLesson_2();

                }
            }
            LessonOfService();
        }

        static void LessonNumber_3()
        {
            Console.WriteLine("Wybrales lekcje nr 3");
            MenuOfLesson();
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
                    //Lesson3Part4();
                    Console.ReadKey();
                }
                else if (option == "5")
                {
                    Console.Clear();
                    //Lesson3Part5();
                    Console.ReadKey();
                }
                else if (option == "6")
                {
                    Console.Clear();
                    //Lesson3Part6();
                    Console.ReadKey();
                }
                else if (option == "7")
                {
                    Console.Clear();
                    //Lesson3Part7();
                    Console.ReadKey();
                }
                else if (option == "8")
                {
                    Console.Clear();
                    //Lesson3Part8();
                    Console.ReadKey();
                }

                else if (option == "9")
                {
                    TaskContentLesson_2();

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
            int firstValue21 = 45;
            int secondValue21 = 80 ;

            /*
             * Napisz program konsolowy, który spróbuje porównać ze sobą dwie zmienne typu int,
             * które zostaną zadeklarowane w kodzie programu. Zwróć uwagę na zachowanie programu
             * i wyświetlone komunikaty.
            */

            if(firstValue21 == secondValue21)
            {
                Console.WriteLine(firstValue21 + " równe " + secondValue21 );
            }
            else if(firstValue21 < secondValue21)
            {
                Console.WriteLine(firstValue21 + " jest mniejsze od " + secondValue21);
            }
            Console.WriteLine(firstValue21 + " jest większe " + secondValue21);
            
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
                Console.WriteLine(firstValue +" = "+ secondValue);
            }
            else if(firstValue < secondValue)
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
            else if(firstValue > secondValue)
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

            if(firstValue == secondValue)
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
            
            if(menuValue == "1") {
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

        static void TaskContentLesson_1()
        {
            Console.WriteLine("Wypisz w konsoli swoje imię i nazwisko, wykorzystując w tym celu wszystkie znane Ci metody wyświetlania komunikatów.");
            Console.WriteLine("Zad. 2. Utwórz dwie zmienne liczbowe i przypisz im wartości. Wyświetl w konsoli wyniki dodawania, odejmowania, mnożenia oraz dzielenia. Niech druga liczba nie będzie zerem. Użyj typu danych double. ");
            Console.WriteLine("Utwórz dwie zmienne liczbowe i przypisz im wartości podane poprzez konsolę. Wyświetl w konsoli wyniki dodawania, odejmowania, mnożenia oraz dzielenia. Niech druga liczba nie będzie zerem. Użyj typu danych double.");
            Console.WriteLine("Utwórz dwie zmienne liczbowe typu double. Dla każdego z działań (dodawanie, odejmowanie, mnożenie i dzielenie) przypisz z konsoli nowy zestaw liczb oraz wypisz ich wyniki w konsoli w formie pełnych działań arytmetycznych($”{ }”).");
        }

        static void TaskContentLesson_2()
        {
            Console.WriteLine("Napisz program konsolowy, który spróbuje porównać ze sobą dwie zmienne typu int, które zostaną zadeklarowane w kodzie programu. Zwróć uwagę na zachowanie programu i wyświetlone komunikaty.");
            Console.WriteLine("Napisz program konsolowy, który porówna ze sobą dwie zmienne typu int ze zdefiniowanymi wartościami, które będą przez Ciebie podane w kodzie. Wypisz wynik porównania w konsoli.");
            Console.WriteLine("Napisz program konsolowy, który porówna ze sobą dwie zmienne typu int, których wartości zostaną pobrane z konsoli. Wypisz wynik porównania w konsoli.");
            Console.WriteLine("Napisz program konsolowy, który sprawdzi, czy wartość pobrana z konsoli jest większa od 5 i mniejsza od 20. Wypisz wynik w konsoli.");
            Console.WriteLine("Napisz program konsolowy, który sprawdzi, czy wartość pobrana z konsoli jest spoza zakresu <5; 20>. Wypisz wynik w konsoli.");
            Console.WriteLine("Napisz program konsolowy, który pobierze z konsoli dwie liczby całkowite, po czym do trzeciej zmiennej przypisze większą wartość. Wykorzystaj przypisanie warunkowe i wypisz wynik w konsoli.");
            Console.WriteLine("Napisz program konsolowy, który pobierze z konsoli długości trzech boków trójkąta. Sprawdź, czy z podanych wartości można utworzyć trójkąt. Wypisz wynik w konsoli.");
            Console.WriteLine("Napisz program konsolowy, który pobierze dwie wartości z konsoli. Wyświetl w konsoli wyniki dodawania, odejmowania, mnożenia oraz dzielenia. Pamiętaj, żeby przy próbie dzielenia przez 0 wyświetlić odpowiedni komunikat, który uniemożliwi przeprowadzenie „zakazanego” działania. Użyj typu danych double.");
        }
    }
}
       
   

