using System;
using System.Dynamic;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Zadanie nr 1");
            /*
             * Wypisz w konsoli swoje imię i nazwisko, wykorzystując
             * w tym celu wszystkie znane Ci metody wyświetlania komunikatów.
            */
            string name;
            string secondname;


            Console.WriteLine("Podaj imię:");
            name = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko:");
            secondname = Console.ReadLine();

            Console.WriteLine("pirwszy sposób prezentacji kodu");
            Console.WriteLine($"{name} {secondname}");
            Console.WriteLine("\n drugi sposób prezentacji kodu");
            Console.WriteLine(name + " " + secondname);


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
            while(secondValueThirdPart == 0)
            {
                Console.WriteLine("Miałeś podać wartość inną niż zero !!!!!!!!!!!!");
                Console.WriteLine("Jeszcze raz, skup się, to proste:");
                Console.WriteLine("Wpisz drugą liczbę inną niż zero: ");
                valueFromConsole = Console.ReadLine();
                secondValueThirdPart = Double.Parse(valueFromConsole);

            }
            Console.WriteLine("Ok, podana druga wartość jest poprawna ");

            sum = firstValueThirdPart + secondValueThirdPart;
            subtraction = firstValueThirdPart - secondValueThirdPart;
            multiplication = firstValueThirdPart * secondValueThirdPart;
            division = firstValueThirdPart / secondValueThirdPart;


            Console.WriteLine($"{firstValueThirdPart} + {secondValueThirdPart} = {sum}");
            Console.WriteLine($"{firstValueThirdPart} - {secondValueThirdPart} = {subtraction}");
            Console.WriteLine($"{firstValueThirdPart} * {secondValueThirdPart} = {multiplication}");
            Console.WriteLine($"{firstValueThirdPart} / {secondValueThirdPart} = {division}");

            Console.WriteLine($"dodawanie: {firstValueThirdPart} + {secondValueThirdPart} = {firstValueThirdPart + secondValueThirdPart}");
            Console.WriteLine($"odejmowanie: {firstValueThirdPart} - {secondValueThirdPart} = {firstValueThirdPart - secondValueThirdPart}");
            Console.WriteLine($"mnożenie: {firstValueThirdPart} * {secondValueThirdPart} = {firstValueThirdPart * secondValueThirdPart}");
            Console.WriteLine($"dzielenie: {firstValueThirdPart} / {secondValueThirdPart} = {firstValueThirdPart / secondValueThirdPart}");


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
            Console.WriteLine("Podaj drugą wartość dzielenia inną niż zero: " );
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
       
    }
}
