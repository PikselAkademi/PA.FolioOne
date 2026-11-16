using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("ResumeCategories")]
    public class ResumeCategory
    {
        [Key] public Guid Id { get; set; }

        [DisplayName("Kategori Konumu")]
        public bool IsLeft { get; set; } = true;

        [DisplayName("Kategori Sırası")]
        public byte Order { get; set; }

        [DisplayName("Kategori Başlığı")]
        [Required(ErrorMessage = "Kategori başlığı boş bırakılamaz.")]
        public string Title { get; set; } = string.Empty;

        public List<ResumeItem>? Items { get; set; }

        public List<ResumeSkill>? Skills { get; set; }
    }
}
