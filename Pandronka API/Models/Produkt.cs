using System.Collections.Generic;

namespace Pandronka.Models
{
    public class Produkt
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public int Ilosc { get; set; }
        public int JednostkaMiaryId { get; set; }
        public virtual JednostkaMiary JednostkaMiary { get; set; }
        public bool Dostepnosc  { get; set; }
        public virtual Kategoria Kategoria  { get; set; }
        public int KategoriaId  { get; set; }
        public virtual Producent Producent { get; set; }
        public int ProducentId { get; set; }
        public double Cena { get; set; }

    }
}