using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("ResumeItems")]
    public class ResumeItem
    {
        [Key] public Guid Id { get; set; }

        [DisplayName("Başlık")]
        [Required(ErrorMessage = "Başlık boş bırakılamaz.")]
        public string Title { get; set; } = string.Empty;

        [DisplayName("Başlangıç Tarihi")]
        [Required(ErrorMessage = "Başlangıç tarihi boş bırakılamaz.")]
        public DateTime StartDate { get; set; }

        [DisplayName("Bitiş Tarihi")]
        public DateTime? EndDate { get; set; }

        [DisplayName("Alt Başlık")]
        [Required(ErrorMessage = "Alt başlık boş bırakılamaz.")]
        public string Subtitle { get; set; } = string.Empty;

        [DisplayName("Açıklama")]
        public string? Description { get; set; }

        [DisplayName("Maddeler")]
        public string? Articles { get; set; }

        [Required(ErrorMessage = "Kategori boş bırakılamaz.")]
        public Guid CategoryId { get; set; }

        //[ForeignKey(nameof(CategoryId))]
        //[ForeignKey("CategoryId")]
        public ResumeCategory? Category { get; set; }

    }
}
