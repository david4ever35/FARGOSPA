namespace FargoSpaAppWellness.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        public string ServiceName { get; set; } = "";
        public DateTime AppointmentDateTime { get; set; }

        public string ProviderName { get; set; } = "";

        public bool IsBooked { get; set; } = false;

        public string? BookedByEmail { get; set; }
    }
}
