using System;
using System.Collections.Generic;
using System.Text;

namespace First.TasksList
{
    public class ListOfTasksForLessonFour
    {
        public void PrintLessonFourTasks()
        {
            List<string> lessonFourTasks = new List<string>();
            lessonFourTasks.Add("1. Napisz program, który wypisze liczby od 0 do podanej przez użytkownika. Pamiętaj o zachowaniu odpowiednich odstępów pomiędzy poszczególnymi liczbami.");
            lessonFourTasks.Add("2. Zmodyfikuj poprzedni program tak, żeby tym razem użytkownik mógł wybrać także liczbę początkową. Zwróć uwagę, czy wypisane są także liczby graniczne.");
            lessonFourTasks.Add("3. Zmodyfikuj program z zad. 1. tak, żeby zamiast wypisywać liczby od 0, zaczął odliczać od liczby podanej przez użytkownika do zera.");
            lessonFourTasks.Add("4. Przerób poprzedni program tak, żeby odliczał tylko w obrębie zakresu podanego jak w zad. 11.");
            lessonFourTasks.Add("5. Napisz program, który w konsoli wypisze tabliczkę mnożenia liczb od 1 do 10.");
            lessonFourTasks.Add("6. Napisz program, który będzie wypisywał w konsoli tabliczkę mnożenia liczb od 1 do liczby podanej przez użytkownika.");
            lessonFourTasks.Add("7. Napisz program, który wypisze w konsoli tylko liczby parzyste z zakresu od 0 do 100.");
            lessonFourTasks.Add("8. Napisz program, który wypisze w konsoli tylko liczby nieparzyste z zakresu od 0 do 100.");
            lessonFourTasks.Add("9. Napisz program, w którym użytkownik będzie mógł wybrać, czy chce wypisać liczby parzyste, czy nieparzyste, z zakresu podanego przez użytkownika.");
            lessonFourTasks.Add("10. Napisz program, który będzie wypisywał liczby podzielne przez 2, 3, 4, 5, 7, 9 z podanego zakresu. Pamiętaj, żeby oddzielić poszczególne działania.");
            lessonFourTasks.Add("11. Zmodyfikuj poprzedni program tak, żeby użytkownik mógł wybrać, który dzielnik chce wybrać.");
            lessonFourTasks.Add("12. Napisz program, który będzie wypisywał wszystkie liczby pierwsze z przedziału od 0 do liczby podanej przez użytkownika.");
            lessonFourTasks.Add("13. Zmodyfikuj poprzedni program tak, żeby użytkownik mógł podać zakres liczb.");
            lessonFourTasks.Add("14. Zmodyfikuj program Kalkulator tak, żeby po zakończeniu obliczeń pytał użytkownika, czy chce kontynuować obliczenia bez wychodzenia z programu. Użytkownik za każdym razem ma podawać liczby, na których chce działać i wybrać działanie.");
            lessonFourTasks.Add("15. Napisz program, który będzie w konsoli za pomocą gwiazdek (*) rysował kwadrat o długości boku podanej przez użytkownika (długość boku = ilość gwiazdek). Pamiętaj o dodaniu odpowiednich odstępów pomiędzy gwiazdkami.");
            lessonFourTasks.Add("16. Zmodyfikuj poprzedni program tak, żeby rysował prostokąt o podanej długości boków.");
            lessonFourTasks.Add("17. Napisz program, który będzie rysował w konsoli za pomocą gwiazdek trójkąt prostokątny równoramienny o wysokości podanej przez użytkownika.");
            lessonFourTasks.Add("18. Napisz program, który będzie rysował w konsoli za pomocą gwiazdek trójkąt równoramienny o długości podstawy podanej przez użytkownika. Weź pod uwagę, czy podana długość jest parzysta, czy nie i uwzględnij podczas implementacji. Podstawa ma być na dole!");


            Console.Clear();
            foreach (string lesson in lessonFourTasks)
            {
                Console.WriteLine(lesson);
            }
            Console.WriteLine("Powrót do listy - naciśnij dowolny klawisz");
            Console.ReadKey();
        }
    }
}
