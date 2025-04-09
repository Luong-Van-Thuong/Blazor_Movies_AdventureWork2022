using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Blazor_Movies_02.Models
{
    public class Model
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public DateOnly ReleaseDate { get; set; }

        public string? Genre { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
