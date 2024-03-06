namespace eltpos.Models
{
    public class Customers
    {
        public int Id { get; set; } 
        public int CustomerId { get; set; }
        public required string CustomerName { get; set; }
        public string CustomerEmail { get; set; } = string.Empty;
        public required string PhoneNumber { get; set; }
        public required string NIDNumber { get; set; }
        public string? DateOfBirth { get; set; }
        public string? Area { get; set;}
        public string? City { get; set;} 
        public string? Post { get; set;}
        public string? PostCode { get; set;}
        public string? Division { get; set;}
        public string? Country { get; set;}

    }
}
