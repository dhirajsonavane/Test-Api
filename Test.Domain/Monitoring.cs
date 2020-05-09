using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test.Domain
{
    [Table("Monitoring", Schema = "dbo")]
    public class Monitoring
    {
        [Key]
        [Required]
        public int ImageId { get; set; }
        public int VehicleId { get; set; }
        public double Time { get; set; }
        public int VehicleType { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Speed { get; set; }
        public double Acceleration { get; set; }
        public double X_Coordinate { get; set; }
        public double Y_Coordinate { get; set; }
    }
}
