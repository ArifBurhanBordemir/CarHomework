using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CarHomework.Models;

namespace CarHomework.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CarHomework.Models.Brand> Brand { get; set; } = default!;
        public DbSet<CarHomework.Models.Car> Car { get; set; } = default!;

        public List<Brand> GetBrands()
        {
            return Brand.ToList();
        }
    }
    
}
