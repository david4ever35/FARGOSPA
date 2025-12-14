using Microsoft.EntityFrameworkCore;
using FargoSpaAppWellness.Models;

namespace FargoSpaAppWellness.Data
{
    public class SpaDbContext : DbContext
    {
        public SpaDbContext(DbContextOptions<SpaDbContext> options) : base(options) { }

        public DbSet<Testimonial> Testimonials { get; set; }

    }
}