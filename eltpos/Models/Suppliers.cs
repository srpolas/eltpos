namespace eltpos.Models
{
    public class Suppliers
    {
        public int Id { get; set; } // Primary key
        public int SupplierId { get; set; }
        public required string SupplierCompany { get; set; } = string.Empty;

        public string? SupplierName { get; set; }
        public string? SupplierType { get; set; }
        public string? SupplierCategory { get; set; }
        public string? ContactPerson { get; set; }
        public string? SupplierEmail { get; set; }
        public required string SupplierPhone { get; set; }
        public string? SupplierAddress { get; set; }
        public string? SupplierCity { get; set; }
    }

}
