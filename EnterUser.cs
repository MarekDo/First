using System;
using System.Collections.Generic;
using System.Text;

namespace First
{
    public class EnterUser
    {

        private string name;
        private string secondname;

        public string Name { get; set; }
        public string Secondname { get; set; }

        public void EnterName()
        {
            Console.WriteLine("Podaj imię:");
            name = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko:");
            secondname = Console.ReadLine();
        }

        public void PrintDateOfUser()
        {
            Console.WriteLine();
            Console.WriteLine($"User is: {name} {secondname}");
        }

        
    }
}
