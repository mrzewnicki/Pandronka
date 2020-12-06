namespace Pandronka.Models
{
    public class Koszyk
    {
        public int Id { get; set; }
        public string UzytkownikId { get; set; }
        public  ApplicationUser Uzytkownik { get; set; }
    }
}