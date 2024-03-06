namespace eltpos.Models
{
    public class Products
    {
        public int Id { get; set; } // primary key
        public int ProductId { get; set; }
        public required string ProductName { get; set; }
        public string? Description { get; set; }
        public required decimal Price { get; set; }
        public int? PackageQuantity { get; set; }
        public string? Category { get; set; }
        public string? Manufacturer { get; set; }
        public decimal WeightInGrams { get; set; } // Weight of the product in grams
        public string? Barcode { get; set; } // Product barcode (e.g., UPC or EAN)
        public DateTime ReleaseDate { get; set; } // Date when the product was released
        public bool ProductionCategory { get; set; } // Indicates if the product is featured
        public string? ImageUrl { get; set; } // URL for the product image
    }


}
