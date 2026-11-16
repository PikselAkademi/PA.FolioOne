using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("Skills")]
    public class Skill
    {
        [Key] public Guid Id { get; set; }

        [DisplayName("Yetenek Adı")]
        [Required(ErrorMessage = "Yetenek adı zorunludur.")]
        public string Title { get; set; } = string.Empty;

        [DisplayName("Yetenek Açıklaması")]
        public string? Description { get; set; }

        [DisplayName("Yetenek Yüzdesi")]
        [Required(ErrorMessage = "Yetenek yüzdesi zorunludur.")]
        [Range(0, 100, ErrorMessage = "Yetenek yüzdesi 0 ile 100 arasında olmalıdır.")]
        public byte Percentage { get; set; }
    }
}
