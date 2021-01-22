namespace Pandronka.Models
{
    public class Zamowienia
    {
        public int Id { get; set; }
        public float Kwota { get; set; }
        public virtual ApplicationUser Uzytkownik  { get; set; }
        public int KoszykId { get; set; }
        public virtual Koszyk Koszyk { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        public int? PlatnoscId { get; set; }
        public virtual Platnosc Platnosc { get; set; }
    }
}