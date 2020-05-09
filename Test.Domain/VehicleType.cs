using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test.Domain
{
    [Table("VehicleType", Schema = "dbo")]
    public class VehicleType
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Monitoring> Monitoring { get; set; } = new List<Monitoring>();
    }
}
