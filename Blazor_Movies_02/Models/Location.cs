using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazor_Movies_02.Models
{
    [Table("Location", Schema = "Production")]
    public class Location
    {
        [Key]
        public short LocationID { get; set; } // Identity, PK
        public string Name { get; set; } = null!;   
        public decimal CostRate { get; set; }
        public decimal Availability { get; set; }
        public DateTime ModifieDate { get; set; } = DateTime.Now; // Default GETDATE()
        public required ICollection<ProductInventory> ProductInventories { get; set; }
    }
}
