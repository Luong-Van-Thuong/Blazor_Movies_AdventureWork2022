using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazor_Movies_02.Models
{
    [Table("ProductInventory", Schema = "Production")]
    public class ProductInventory
    {
        [Key]
        public int ProductID { get; set; } // PK, FK
        public short LocationID { get; set; } // PK, FK
        public required string Shelf { get; set; }
        public byte Bin { get; set; }
        public short Quantity { get; set; }

        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; } = DateTime.Now;

        // Navigation properties
        public virtual Product? Product { get; set; }
        public virtual Location? Location { get; set; }
    }
}
