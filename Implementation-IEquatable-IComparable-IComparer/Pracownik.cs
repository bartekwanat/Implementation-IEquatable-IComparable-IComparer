using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation_IEquatable_IComparable_IComparer
{
    public class Pracownik
    {
        private string nazwisko;
        public string Nazwisko { 
            get => nazwisko;
            set => nazwisko = String.Concat(value.Where(c => !char.IsWhiteSpace(c)));
                 }

        private DateTime dataZatrudnienia;
        public DateTime? DataZatrudnienia 
        { 
            get => dataZatrudnienia;
            set {
                if (dataZatrudnienia > DateTime.Now)
                    throw new ArgumentException();
            } 
        }

        private decimal wynagrodzenie;
        public decimal Wynagrodzenie
        {
            get => wynagrodzenie;
            set
            {
                if (wynagrodzenie < 0 ) wynagrodzenie = 0;
            }
        }

    }
}
