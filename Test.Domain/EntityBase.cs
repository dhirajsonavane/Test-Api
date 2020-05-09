using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test.Domain
{
    public abstract class EntityBase
    {
        [Key]
        [Required]
        [Column(TypeName = "uniqueidentifier")]
        public Guid Id { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        [Column(TypeName = "DateTime")]
        [Required]
        public DateTime CreatedDate { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? UpdatedDate { get; set; }
    }
}
