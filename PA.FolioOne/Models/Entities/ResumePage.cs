using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("ResumePages")]
    public class ResumePage
    {
        [Key] public Guid Id { get; set; }

        [DisplayName("Başlık")]
        [Required(ErrorMessage = "Başlık alanı boş geçilemez.")]
        public string Title { get; set; } = string.Empty;

        [DisplayName("Açıklama")]
        [Required(ErrorMessage = "Açıklama alanı boş geçilemez.")]
        public string Description { get; set; } = string.Empty;
    }
}
