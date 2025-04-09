using System.ComponentModel.DataAnnotations.Schema;

namespace Blazor_Movies_02.Models
{
    [Table("Product", Schema = "Production")]
    public class Product
    {
        public int ProductID { get; set; } // Identity, PK

        public string Name { get; set; } = null!;

        public string ProductNumber { get; set; } = null!;

        public bool MakeFlag { get; set; } = true; // Default 1

        public bool FinishedGoodsFlag { get; set; } = true; // Default 1

        public string? Color { get; set; }

        public short SafetyStockLevel { get; set; }

        public short ReorderPoint { get; set; }

        public decimal StandardCost { get; set; }

        public decimal ListPrice { get; set; }

        public string? Size { get; set; }

        public string? SizeUnitMeasureCode { get; set; }

        public string? WeightUnitMeasureCode { get; set; }

        public decimal? Weight { get; set; }

        public int DaysToManufacture { get; set; }

        public string? ProductLine { get; set; } // R/M/T/S

        public string? Class { get; set; } // H/M/L

        public string? Style { get; set; } // U/M/W

        public int? ProductSubcategoryID { get; set; }

        public int? ProductModelID { get; set; }

        public DateTime SellStartDate { get; set; }

        public DateTime? SellEndDate { get; set; }

        public DateTime? DiscontinuedDate { get; set; }

        public Guid Rowguid { get; set; } = Guid.NewGuid(); // Default NEWID()

        public DateTime ModifiedDate { get; set; } = DateTime.Now; // Default GETDATE()

        public required ICollection<ProductInventory> ProductInventories { get; set; }
    }
}
