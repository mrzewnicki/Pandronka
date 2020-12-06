namespace Pandronka.Models
{
    public class Zamowienia
    {
        public int Id { get; set; }
        public float Kwota { get; set; }
        public virtual ApplicationUser Uzytkownik  { get; set; }
        public virtual Koszyk Koszyk { get; set; }
        public virtual Status Status { get; set; }
    }
}