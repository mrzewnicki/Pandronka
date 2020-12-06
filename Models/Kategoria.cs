using System.Collections.Generic;

namespace Pandronka.Models
{
    public class Kategoria
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public virtual ICollection<Produkt> Produkt { get; set; }
    }
}