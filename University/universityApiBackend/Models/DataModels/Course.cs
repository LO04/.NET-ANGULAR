using System.ComponentModel.DataAnnotations;

namespace universityApiBackend.Models.DataModels
{
    public class Course:BaseEntity
    {
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(280)]
        public string shortDescription { get; set; } = string.Empty; 
        public string largeDescription { get; set; } = string.Empty; 
        public string objetivePublic{ get; set; } = string.Empty; 
        public string Objetives{ get; set; } = string.Empty; 
        public string Requirements{ get; set; } = string.Empty; 
        public int? Level { get; set; }
        
    }
}
