using System;

namespace Implementation_IEquatable_IComparable_IComparer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var pracownik = new Pracownik();
            pracownik.Nazwisko = "    Bart     ";
            pracownik.Wynagrodzenie = 100;
            pracownik.DataZatrudnienia = new DateTime(2010, 10, 01);
            Console.WriteLine(pracownik.Nazwisko);

        }
    }
}
