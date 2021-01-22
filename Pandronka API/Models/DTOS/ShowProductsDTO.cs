using Pandronka.Models;

namespace Pandronka_API.Models.DTOS
{
    public class ShowProductsDTO
    {

        public ShowProductsDTO()
        {
            
        }

        public ShowProductsDTO(Produkt row)
        {
            Nazwa = row.Nazwa;
            Id = row.Id;
            Cena = row.Cena;

            if (row.Kategoria != null)
            {
                Kategoria = row.Kategoria.Nazwa;
            }
        }

        public string Nazwa { get; set; }
        public int Id { get; set; }
        public string Kategoria { get; set; }
        public double Cena { get; set; }
    }
}