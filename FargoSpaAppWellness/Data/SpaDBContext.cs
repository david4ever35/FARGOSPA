using Microsoft.EntityFrameworkCore;
using FargoSpaAndWellness.Models;

namespace FargoSpaAppWellness.Data
{
    public class SpaDbContext : DbContext
    {
        public SpaDbContext(DbContextOptions<SpaDbContext> options) : base(options) { }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Manager> Managers { get; set; }
    }
}