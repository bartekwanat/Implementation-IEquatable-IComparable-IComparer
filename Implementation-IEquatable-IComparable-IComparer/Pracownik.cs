using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation_IEquatable_IComparable_IComparer
{
    public class Pracownik : IEquatable<Pracownik>, IComparable<Pracownik>
    {
        private string nazwisko;
        public string Nazwisko
        {
            get => nazwisko;
            set => nazwisko = String.Concat(value.Where(c => !char.IsWhiteSpace(c)));
        }

        private DateTime dataZatrudnienia;
        public DateTime DataZatrudnienia
        {
            get => dataZatrudnienia;
            set
            {
                if (dataZatrudnienia > DateTime.Now)
                {
                    throw new ArgumentException();
                }
                else dataZatrudnienia = value;
            }
        }

        private decimal wynagrodzenie;
        public decimal Wynagrodzenie
        {
            get => wynagrodzenie;
            set
            {
                if (wynagrodzenie < 0) wynagrodzenie = 0;
                else wynagrodzenie = value;
            }
        }

        public int CzasZatrudnienia
        {
            get => (DateTime.Now - DataZatrudnienia).Days / 30;
        }


        public Pracownik()
        {
            Nazwisko = "Anonim";
            DataZatrudnienia = DateTime.Now;
            Wynagrodzenie = 0;
        }

        public Pracownik(string nazwisko, DateTime dataZatrudnienia, decimal wynagrodzenie)
        {
            Nazwisko = nazwisko;
            DataZatrudnienia = dataZatrudnienia;
            Wynagrodzenie = wynagrodzenie;
        }

        public override string ToString()
        {
            return $"{Nazwisko}, {DataZatrudnienia: d MMM yyyy} ({CzasZatrudnienia}), {Wynagrodzenie}";
        }

        public bool Equals(Pracownik pracownik)
        {
            if (pracownik == null) return false;
            if (Object.ReferenceEquals(this, pracownik)) return true;

            return (Nazwisko == pracownik.Nazwisko &&
                DataZatrudnienia == pracownik.DataZatrudnienia &&
                Wynagrodzenie == pracownik.Wynagrodzenie);
        }

        public override bool Equals(object obj)
        {
            if (obj is Pracownik)
                return Equals((Pracownik)obj);
            else
                return false;
        }

        public override int GetHashCode() => (Nazwisko, DataZatrudnienia, Wynagrodzenie).GetHashCode();

        public static bool Equals(Pracownik p1, Pracownik p2)
        {
            if (p1 is null || p2 is null) return false;
            if (p1 is null && p2 is null) return true;

            return p1.Equals(p2);
        }

        public int CompareTo(Pracownik other)
        {
            if (other is null) return 1;
            if (this.Equals(other)) return 0;

            if (this.Nazwisko != other.Nazwisko)
                return this.Nazwisko.CompareTo(other.Nazwisko);

            if (!this.DataZatrudnienia.Equals(other.DataZatrudnienia))
                return this.DataZatrudnienia.CompareTo(other.DataZatrudnienia);

            return this.Wynagrodzenie.CompareTo(other.Wynagrodzenie);
        }

        public static bool operator ==(Pracownik p1, Pracownik p2) => Equals(p1, p2);
        public static bool operator !=(Pracownik p1, Pracownik p2) => !(p1 == p2);


    }
}
