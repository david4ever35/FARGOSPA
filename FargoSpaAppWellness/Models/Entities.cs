namespace FargoSpaAndWellness.Models
{
    // Booking ties together Customer, Service, and Employee
    public class Booking
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int ServiceId { get; set; }
        public Service Service { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public DateTime Date { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public string Notes { get; set; } = string.Empty;
        public string Status { get; set; } = "Confirmed"; // Confirmed, Cancelled, Pending
    }

    // Services offered by the spa
    public class Service
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }
        public int DurationMinutes { get; set; }

        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }

    // Customers who book services
    public class Customer
    {
        public int Id { get; set; }

        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;

        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
        public ICollection<Testimonial> Testimonials { get; set; } = new List<Testimonial>();
    }

    // Employees who provide services
    public class Employee
    {
        public int Id { get; set; }

        public string FullName { get; set; } = string.Empty;
        public string Role { get; set; } = "Massage Therapist";
        public string Email { get; set; } = string.Empty;

        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }

    // Customer reviews/testimonials
    public class Testimonial
    {
        public int Id { get; set; }

        public int Rating { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Remarks { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.Now;
    }

    // Manager (optional, if you want a separate role table)
    public class Manager
    {
        public int Id { get; set; }

        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
        public ICollection<Service> Services { get; set; } = new List<Service>();
    }
}
