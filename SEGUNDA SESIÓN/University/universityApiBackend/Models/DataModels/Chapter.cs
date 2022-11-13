using System.ComponentModel.DataAnnotations;

namespace universityApiBackend.Models.DataModels
{
    public class Chapter: BaseEntity
    {
        public int CourseId {get;set;}
        public virtual Course Course {get;set;}=new Course();
        [Required]
        public string ListChapters { get; set; }=string.Empty;
    }
}
