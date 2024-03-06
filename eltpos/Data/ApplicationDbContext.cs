using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using eltpos.Models;

namespace eltpos.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<eltpos.Models.Customers> Customers { get; set; } = default!;
        public DbSet<eltpos.Models.Suppliers> Suppliers { get; set; } = default!;
    }
}
