namespace Test.DTO
{
    public class Monitoring : EntityBase
    {
        public int ImageId { get; set; }
        public int VehicleId { get; set; }
        public float Time { get; set; }
        public string VehicleType { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public decimal Speed { get; set; }
        public decimal Acceleration { get; set; }
        public decimal X_Coordinate { get; set; }
        public decimal Y_Coordinate { get; set; }
    }
}