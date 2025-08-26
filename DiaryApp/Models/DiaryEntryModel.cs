using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntryModel
    {
        [Key]
        public int EntryId { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Content { get; set; } = string.Empty;
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
