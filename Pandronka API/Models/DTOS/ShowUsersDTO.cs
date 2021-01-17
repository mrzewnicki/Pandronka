using System.ComponentModel.DataAnnotations;

namespace Pandronka_API.Models.DTOS
{
    public class ShowUsersDTO
    {
        public string Login { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public bool Aktywnosc { get; set; }
        public string Rola { get; set; }
    }
}