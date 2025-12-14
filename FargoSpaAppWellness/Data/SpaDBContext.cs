using Microsoft.EntityFrameworkCore;
using FargoSpaAppWellness.Models;

namespace FargoSpaAppWellness.Data
{
    public class SpaDbContext : DbContext
    {
        public SpaDbContext(DbContextOptions<SpaDbContext> options)
            : base(options)
        {
            Database.EnsureCreated(); // 👈 KEY FOR PLUG-AND-PLAY
        }

        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
