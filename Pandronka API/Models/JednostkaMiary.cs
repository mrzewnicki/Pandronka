using System.Collections.Generic;

namespace Pandronka.Models
{
    public class JednostkaMiary
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public virtual ICollection<Produkt> Produkt { get; set; }
    }
}