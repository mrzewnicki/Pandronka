using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Pandronka_API.Models.DTOS
{
    public class AddProductDTO
    {
        [Required(ErrorMessage="Nazwa produktu jest wymagany")]
        [Display(Name="Nazwa produktu ")]
        public string Nazwa { get; set; }
        [Required(ErrorMessage="Ilośc jest wymagany")]
        [Display(Name="Ilość ")]
        public int Ilosc { get; set; }
        [Required(ErrorMessage="Jednostka miary jest wymagana")]
        [Display(Name="Jednostka miary ")]
        public int JednostkaMiaryId { get; set; }
        public IEnumerable<SelectListItem> JednostkiMiary { get; set; }
        [Display(Name="Dostępność produktu")]
        public bool Dostepnosc { get; set; }
        [Required(ErrorMessage="Kategoria produktu jest wymagana")]
        [Display(Name="Kategoria produktu")]
        public int KategoriaId { get; set; }
        public IEnumerable<SelectListItem> Kategorie { get; set; }
        [Required(ErrorMessage="Producent jest wymagany")]
        [Display(Name="Producent")]
        public int ProducentId { get; set; }
        public IEnumerable<SelectListItem> Producenci { get; set; }
        [Required(ErrorMessage="Cena jest wymagany")]
        [Display(Name="Cena ")]
        public float Cena { get; set; }
    }
}