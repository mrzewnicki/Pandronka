using System.ComponentModel.DataAnnotations;

namespace Pandronka.Models
{
    public class Miasto
    {
        [Key]
        public int Id { get; set; }
        public string ViewName { get; set; }
        public string? SubName{ get; set; }
        public string PostalCode { get; set; }
    }
}
