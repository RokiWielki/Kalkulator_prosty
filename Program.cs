//Napisz program – prosty kalkulator, który wczytuje od użytkownika wartości dwóch
//zmiennych typu double oraz znak operacji (+ lub – lub * lub /), a następnie wyświetla wynik 
//operacji dla podanych wartości. Przykładowo użytkownik wprowadził znak „+” i liczby 1,5
//oraz 2,5, program powinien wyświetlić sumę obu liczb, czyli 4,0.
using System;

namespace Kalkulator_prosty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadź znak operacji (+ lub – lub * lub /)");
            char x = char.Parse(Console.ReadLine());
            switch (x)
            {
                case '+': Dod(a, b); break;
                case '-': Odj(a, b); break;
                case '*': Mno(a, b); break;
                case '/': Dze(a, b); break;

            }
        }
        static void Dod(double a,double b)
        {
            Console.WriteLine(a + b);
        }
        static void Odj(double a, double b)
        {
            Console.WriteLine(a - b);
        }
        static void Mno(double a, double b)
        {
            Console.WriteLine(a * b);
        }
        static void Dze(double a, double b)
        {
            if (b == 0) 
                Console.WriteLine("Nie można dzielić przez 0 ! ");
            else
                Console.WriteLine(a / b);
        }
    }
}
