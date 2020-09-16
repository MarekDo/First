﻿using System;
using System.Dynamic;

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
            else if (option == "15")
                Console.Clear();
                Console.WriteLine("Dziękuję za udział i do zobaczenia:");
                return;


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
                    TaskContent();

                }

            }
            LessonOfService();
        }
    

        static void TaskContent()
        {
            Console.WriteLine("Wypisz w konsoli swoje imię i nazwisko, wykorzystując w tym celu wszystkie znane Ci metody wyświetlania komunikatów.");
            Console.WriteLine("Zad. 2. Utwórz dwie zmienne liczbowe i przypisz im wartości. Wyświetl w konsoli wyniki dodawania, odejmowania, mnożenia oraz dzielenia. Niech druga liczba nie będzie zerem. Użyj typu danych double. ");
            Console.WriteLine("Utwórz dwie zmienne liczbowe i przypisz im wartości podane poprzez konsolę. Wyświetl w konsoli wyniki dodawania, odejmowania, mnożenia oraz dzielenia. Niech druga liczba nie będzie zerem. Użyj typu danych double.");
            Console.WriteLine("Utwórz dwie zmienne liczbowe typu double. Dla każdego z działań (dodawanie, odejmowanie, mnożenie i dzielenie) przypisz z konsoli nowy zestaw liczb oraz wypisz ich wyniki w konsoli w formie pełnych działań arytmetycznych($”{ }”).");
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

            if(firstValue21 < secondValue21)
            {
                Console.WriteLine(firstValue21 + " jest mniejsze od " + secondValue21 );
            }
            else
            {
                Console.WriteLine(firstValue21 + " jest mniejsze od " + secondValue21);
            }

            Console.ReadKey();

        }
    }
}
       
   

