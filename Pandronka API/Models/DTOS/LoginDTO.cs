using System.ComponentModel.DataAnnotations;

namespace Pandronka_API.Models.DTO
{
    public class LoginDTO
    {
        [Required(ErrorMessage="Podaj login")]
        [Display(Name="Login")]
        public string Login { get; set; }
        [Required(ErrorMessage="Podaj hasło")]
        [Display(Name="Hasło")]
        public string Haslo { get; set; }
    }
}