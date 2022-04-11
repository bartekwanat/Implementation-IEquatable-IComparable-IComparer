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
          
        public DateTime? DataZatrudnienia { get; set; }
        public decimal Wynagrodzenie { get; set; }

    }
}
