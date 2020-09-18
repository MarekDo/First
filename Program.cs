using System;
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
            double scondSide;
            double thirdSide;


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
       
   

