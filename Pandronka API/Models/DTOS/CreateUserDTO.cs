using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Pandronka_API.Models.DTOS
{
    public class CreateUserDTO
    {
        [Required(ErrorMessage="Podaj login")]
        [Display(Name="Login")]
        public string Login { get; set; }
        [Required(ErrorMessage="Podaj hasło")]
        [Display(Name="Hasło")]
        public string Haslo { get; set; }
        [Required(ErrorMessage="Powtórz hasło")]
        [Display(Name="Potwierdź hasło")]
        [DataType(DataType.Password)]  
        [Compare("Password", ErrorMessage="Hasła nie pasują do siebie!")] 
        public string PowtorzHaslo { get; set; }
        [Required(ErrorMessage="Podaj imię")]
        [Display(Name="Imie")]
        public string Imie { get; set; }
        [Required(ErrorMessage="Podaj nazwisko")]
        [Display(Name="Nazwisko")]
        public string Nazwisko { get; set; }
        [Required(ErrorMessage="Miejscowość jest wymagana")]
        [Display(Name="Miejscowość")]
        public string Miejscowosc { get; set; }
        [Required(ErrorMessage="Ulica jest wymagana")]
        [Display(Name="Ulica")]
        public string Ulica { get; set; }
        [Required(ErrorMessage="Numer domu jest wymagany")]
        [Display(Name="Hasło")]
        public string NumerDomu { get; set; }
        [Required(ErrorMessage="Kod pocztowy jest wymagany")]
        [Display(Name="Kod pocztowy")]
        [RegularExpression(@"[0-9]{2}-[0-9]{3}", ErrorMessage="Podaj prawidłowy kod pocztowy")]
        public string KodPocztowy { get; set; }
        [Required(ErrorMessage="Adres mailowy jest wymagany")]
        [EmailAddress(ErrorMessage="Podaj prawidłowy adres mailowy")]
        [Display(Name="Adres mailowy")]
        public string Email { get; set; }
        [Required(ErrorMessage="Numer telefonu jest wymagany")]
        [Display(Name="Numer telefonu")]
        public string NumerTelefonu { get; set; }
        [Required(ErrorMessage="Rola w systemie jest wymagana")]
        [Display(Name="Wybierz rolę użytkownika")]
        public string Rola { get; set; }
        public IEnumerable<SelectListItem> Role { get; set; }
    }
}