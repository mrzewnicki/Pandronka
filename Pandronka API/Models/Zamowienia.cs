using System.ComponentModel.DataAnnotations.Schema;

namespace Pandronka.Models
{
    public class Zamowienie
    {
        public int Id { get; set; }
        public float Kwota { get; set; }
        public string WykonujacyId { get; set; }
        public virtual ApplicationUser Wykonujacy { get; set; }
        public int KoszykId { get; set; }
        public virtual Koszyk Koszyk { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        public int? PlatnoscId { get; set; }
        public virtual Platnosc Platnosc { get; set; }
    }
}