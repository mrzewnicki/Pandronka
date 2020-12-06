using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Pandronka.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Miejscowosc { get; set; }
        public string Ulica { get; set; }
        public string NumerDomu { get; set; }
        public string KodPocztowy { get; set; }
        public  Koszyk Koszyk { get; set; }
        public virtual ICollection<Zamowienia> Zamowienia { get; set; }
        
    }
}