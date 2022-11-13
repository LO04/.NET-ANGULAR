using System.ComponentModel.DataAnnotations;

namespace universityApiBackend.Models.DataModels
{
    public enum Level
    {
        Basic,
        Medium,
        Advanced,
        Expert
    }
    public class Course: BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } =String.Empty;
        [Required, StringLength(280)]
        public string ShortDescription { get; set; } =String.Empty;
        [Required]
        public string Description { get; set; } =String.Empty;
        public Level Level { get; set; }=Level.Basic;
        [Required]
        public ICollection<Category> categories { get; set; }=new List<Category>();
        [Required]
        public Chapter chapter { get; set; }=new Chapter();
        [Required]
        public ICollection<Student> students { get; set; }=new List<Student>();
    }
}
