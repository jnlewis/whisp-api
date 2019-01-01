using System;

namespace Whisp.Domain.Entities
{
    public class VehicleRegistration
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string RegistrationNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}
