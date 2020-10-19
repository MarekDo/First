using System;
using System.Collections.Generic;
using System.Text;

namespace First.TasksList
{
    public class ListOfTasksForLessonThree
    {
        private List<string> lessonThreeTasks;

        public ListOfTasksForLessonThree()
        {
            lessonThreeTasks = new List<string>();
            lessonThreeTasks.Add("1. Napisz kalkulator, w którym użytkownik poda dwie liczby, a następnie wybierze działanie, które chce wykonać (1. Dodawanie, 2. Odejmowanie, 3. Mnożenie, 4. Dzielenie) i otrzyma w konsoli gotowy wynik. Przy konstruowaniu logiki menu wyboru działania zastosuj konstrukcję if…else, którą zagęścisz (warunek w warunku). Pamiętaj cholero, nie dziel przez 0! Co, jeśli użytkownik poda działanie nieprawidłowo?");
            lessonThreeTasks.Add("2. Wykonaj Zad. 1. modyfikując strukturę if…else na if…else if…else. Dostrzegasz różnicę?");
            lessonThreeTasks.Add("3. Wykonaj Zad. 1. wykorzystując tym razem blok switch…case. Która wersja programu Twoim zdaniem jest czytelniejsza?");
            lessonThreeTasks.Add("4. Utwórz 4 metody: dodawanie (Addition), odejmowanie (Substraction), mnożenie (Multiplication), dzielenie (Division). Wykorzystaj je w kalkulatorze, z Zad. 2. bądź Zad. 3., którego zapis jest Twoim zdaniem czytelniejszy. Jak bardzo skrócił się kod Twojego programu?");
            lessonThreeTasks.Add("5. Utwórz jeszcze 3 metody: dzielenie z resztą, druga potęga, trzecia potęga (nazewnictwo wedle uznania). Dodaj je do swojego kalkulatora.");
            lessonThreeTasks.Add("6. Na rozluźnienie szarych komórek, dodaj do swojego kalkulatora możliwość rezygnacji z obliczeń 😉");
            lessonThreeTasks.Add("7. Napisz program, który będzie wypisywał pierwiastki równania kwadratowego o postaci ax2 + bx + c = 0. niech użytkownik poda wartości liczb a, b i c sprawdź, czy są pierwiastki, czy są jeden, czy dwa wypisz rozwiązania równania kwadratowego w konsoli, a jeśli takowych brak - stosowny komunikat.");
            lessonThreeTasks.Add("8. Napisz program, który będzie liczył pole i obwód figury. Rozwiązując zadanie daj: menu wyboru figury  możliwość podania długości boków, podstaw, promienia bądź wysokości w zależności od figury wypisz wyniki w konsoli. Napisz algorytmy dla: kwadratu, prostokąta, trójkąta, trapezu, koła, rombu i równoległoboku.");
        }
        public void PrintLessonThreeTasks()
        {
            Console.Clear();
            foreach (string lesson in lessonThreeTasks)
            {
                Console.WriteLine(lesson);
                Console.WriteLine();
            }
            Console.WriteLine("Powrót do listy - naciśnij dowolny klawisz");
            Console.ReadKey();
        }
        public string PrintLessonThreeTasks(int numberOfLesson)
        {
            return lessonThreeTasks[numberOfLesson - 1];
        }
    }
}
