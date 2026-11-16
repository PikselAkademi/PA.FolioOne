using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("AboutBadges")]
    public class AboutBadge
    {
        [Key] public Guid Id { get; set; }

        [DisplayName("İkon Sınıfı")]
        [Required(ErrorMessage = "İkon sınıfı zorunludur.")]
        public string IconClass { get; set; } = string.Empty;

        [DisplayName("Başlık")]
        [Required(ErrorMessage = "Başlık alanı zorunludur.")]
        public string Title { get; set; } = string.Empty;

        [DisplayName("Sıra")]
        public byte Order { get; set; }
    }
}
