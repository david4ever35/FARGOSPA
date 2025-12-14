namespace FargoSpaAppWellness.Models
{
    public class Testimonial
    {
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public string Message { get; set; } = "";

        public int Rating { get; set; } = 5; // maybe make it a default value of 5
    }
}
