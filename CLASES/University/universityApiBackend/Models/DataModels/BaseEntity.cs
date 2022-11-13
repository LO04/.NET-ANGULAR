using System.ComponentModel.DataAnnotations;

namespace universityApiBackend.Models.DataModels
{
    public class BaseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User? CreatedBy { get; set; } = new User();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public virtual string UpdatedBy { get; set; } = string.Empty;
        public DateTime UpdatedAt { get; set; }
        public virtual string DeletedBy { get; set; } = string.Empty;
        public DateTime DeletedAt { get; set; }
        public bool IsDeleted { get; set; }


    }
}
