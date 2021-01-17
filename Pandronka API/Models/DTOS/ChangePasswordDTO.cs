using System.ComponentModel.DataAnnotations;

namespace Pandronka_API.Models.DTOS
{
    public class ChangePasswordDTO
    {
        [Required(ErrorMessage="Numer telefonu jest wymagany")]
        [Display(Name="Numer telefonu")]
        public string Email { get; set; }
        [Required(ErrorMessage="Podaj hasło")]
        [Display(Name="Hasło")]
        public string Haslo { get; set; }
        [Required(ErrorMessage="Powtórz hasło")]
        [Display(Name="Potwierdź hasło")]
        [DataType(DataType.Password)]  
        [Compare("Password", ErrorMessage="Hasła nie pasują do siebie!")] 
        public string PotwierdzHaslo { get; set; }
    }
}