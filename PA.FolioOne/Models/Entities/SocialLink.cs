using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("SocialLinks")]
    public class SocialLink
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Sosyal medya icon sınıfı zorunludur.")]
        public string IconClass { get; set; } = string.Empty;

        [Required(ErrorMessage = "Sosyal medya bağlantısı zorunludur.")]
        [Url(ErrorMessage = "Geçerli bir URL girin.")]
        public string Url { get; set; } = string.Empty;

        [Required(ErrorMessage = "Sıra bilgisi zorunludur.")]
        [Range(1, 8, ErrorMessage = "Sıra numarası en az 1 en fazla 8 olabilir.")]
        public byte Order { get; set; }
    }
}
