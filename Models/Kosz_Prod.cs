using Microsoft.EntityFrameworkCore;

namespace Pandronka.Models
{
    [Keyless]
    public class Kosz_Prod
    {
        public virtual Produkt Produkt { get; set; }
        public virtual Koszyk Koszyk { get; set; }
    }
}