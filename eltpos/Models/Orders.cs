namespace eltpos.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public required string PoductName { get; set; }
        public decimal ProductAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public string? Status { get; set; }
        public string? ShippingAddress { get; set; }
        public string? PaymentMethod { get; set; }
        public decimal? DiscountAmount { get; set; } // Optional: If you offer discounts
        public decimal? TaxAmount { get; set; } // Optional: For taxes
        public string? Notes { get; set; } // Optional: Additional notes
        public string? MarketingOfficer { get; set; }
    }
}
