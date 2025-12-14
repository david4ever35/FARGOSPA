namespace FargoSpaAppWellness.Models
{
    public class Testimonial
    {
        public int Id { get; set; }          // REQUIRED for EF
        public string Name { get; set; } = "";
        public string Message { get; set; } = "";
    }
}
