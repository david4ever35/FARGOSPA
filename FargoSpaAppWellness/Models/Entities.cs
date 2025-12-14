namespace FargoSpaAppWellness.Models
{
    public class Testimonial
    {
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public string Message { get; set; } = "";

        public int Rating { get; set; } = 5; // maybe make it a default value of 5
    }


    public class AppUser
    {
        public int Id { get; set; }

        public string Email { get; set; } = "";

        public string Password { get; set; } = ""; // plaintext (school project)

        public string Role { get; set; } = "User"; // Admin | User
    }
    

}
