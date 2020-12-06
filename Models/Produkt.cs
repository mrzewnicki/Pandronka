using System.Collections.Generic;

namespace Pandronka.Models
{
    public class Produkt
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public int Ilosc { get; set; }
        public virtual JednostkaMiary JednostkaMiary { get; set; }
        public bool Dostepnosc  { get; set; }
        public virtual Kategoria Kategoria  { get; set; }
        public virtual Producent Producent { get; set; }
        public float Cena { get; set; }

    }
}