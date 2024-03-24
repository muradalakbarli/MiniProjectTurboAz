using System;
namespace TurboAz
{
    using System.ComponentModel.DataAnnotations;

    public class Model
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        [StringLength(100)]
        public string LastModifiedBy { get; set; }

        public DateTime LastModifiedAt { get; set; }

        [StringLength(100)]
        public string DeletedBy { get; set; }

        public DateTime? DeletedAt { get; set; }
    }

}

