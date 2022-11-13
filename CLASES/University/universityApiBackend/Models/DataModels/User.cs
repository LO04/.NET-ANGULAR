using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace universityApiBackend.Models.DataModels
{
    public class User: BaseEntity
    {
        [Required,StringLength(50)]
        public string Name { get; set; }= string.Empty;
        [Required, StringLength(100)]
        public string Apellidos { get; set; }= string.Empty;
        [Required,EmailAddress]
        public string Email { get; set; }= string.Empty;
        [Required]
        public string Password { get; set; }= string.Empty;
        
        [InverseProperty("CreatedBy")]
        public ICollection<BaseEntity>? BEntityCreatedBy { get; set; }
        /*[InverseProperty("UpdatedBy")]
        public ICollection<BaseEntity>? BEntityUpdateBy { get; set; }
        [InverseProperty("DeletedBy")]
        public ICollection<BaseEntity>? BEntityDeletedBy { get; set; }*/
    }
}
