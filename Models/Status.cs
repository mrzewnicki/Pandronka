using System.Collections.Generic;

namespace Pandronka.Models
{
    public class Status
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public virtual ICollection<Zamowienia> Zamowienia { get; set; }
    }
}