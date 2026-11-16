using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("ResumeSkills")]
    public class ResumeSkill
    {
        [Key] public Guid Id { get; set; }

        [DisplayName("Başlık")]
        [Required(ErrorMessage = "Başlık boş bırakılamaz.")]
        public string Title { get; set; } = string.Empty;

        [DisplayName("Yüzde")]
        [Range(0, 100, ErrorMessage = "Yüzde 0 ile 100 arasında olmalıdır.")]
        public byte Percentage { get; set; }

        [DisplayName("Yetenek Sırası")]
        public byte Order { get; set; }

        [Required(ErrorMessage = "Kategori boş bırakılamaz.")]
        public Guid CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public ResumeCategory? Category { get; set; }
    }
}
