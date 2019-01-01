namespace Whisp.Application.RequestModels
{
    public class VehicleRegisterRequest
    {
        public long UserId { get; set; }
        public string RegistrationNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}