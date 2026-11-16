using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("TimeLines")]
    public class TimeLine
    {
        [DisplayName("Kimlik")]
        [Key] public Guid Id { get; set; }

        [DisplayName("Tarih")]
        [Required(ErrorMessage = "Tarih alanı zorunludur.")]
        public DateOnly Date { get; set; }

        [DisplayName("Başlık")]
        [Required(ErrorMessage = "Başlık alanı zorunludur.")]
        [MaxLength(50, ErrorMessage = "Başlık en fazla 50 karakter olabilir.")]
        public string Title { get; set; } = string.Empty;

        [DisplayName("Açıklama")]
        [Required(ErrorMessage = "Açıklama alanı zorunludur.")]
        [MaxLength(150, ErrorMessage = "Açıklama en fazla 150 karakter olabilir.")]
        public string Description { get; set; } = string.Empty;

    }
}
