using System;

namespace Implementation_IEquatable_IComparable_IComparer
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            var pracownik = new Pracownik();
            pracownik.Nazwisko = "  Adam       ";
            pracownik.DataZatrudnienia = new DateTime(2010, 04, 10);
            pracownik.Wynagrodzenie = 1500;
            Console.WriteLine(pracownik.ToString());

        }
    }
}
