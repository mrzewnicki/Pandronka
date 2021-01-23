using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Pandronka_API.Models.DTOS;

namespace Pandronka.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            
        }

        public ApplicationUser(RegisterDTO toMap)
        {
            Imie = toMap.Imie;
            Nazwisko = toMap.Nazwisko;
            Miejscowosc = toMap.Miejscowosc;
            Ulica = toMap.Ulica;
            NumerDomu = toMap.NumerDomu;
            KodPocztowy = toMap.KodPocztowy;
            Email = toMap.Email;
            NumerTelefonu = toMap.NumerTelefonu;
        }

        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Miejscowosc { get; set; }
        public string Ulica { get; set; }
        public string NumerDomu { get; set; }
        public string KodPocztowy { get; set; }
        public string Email { get; set; }
        public string NumerTelefonu { get; set; }
        public  Koszyk Koszyk { get; set; }
        public virtual ICollection<Zamowienia> Wykonane { get; set; }

    }
}