using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("SocialLinks")]
    public class SocialLink
    {
        [DisplayName("Kimlik")]
        [Key]
        public Guid Id { get; set; }

        [DisplayName("İkon Sınıfı")]
        [Required(ErrorMessage = "Sosyal medya icon sınıfı zorunludur.")]
        public string IconClass { get; set; } = string.Empty;

        [DisplayName("URL")]
        [Required(ErrorMessage = "Sosyal medya bağlantısı zorunludur.")]
        [Url(ErrorMessage = "Geçerli bir URL girin.")]
        public string Url { get; set; } = string.Empty;

        [DisplayName("Sıra")]
        [Required(ErrorMessage = "Sıra bilgisi zorunludur.")]
        [Range(1, 8, ErrorMessage = "Sıra numarası en az 1 en fazla 8 olabilir.")]
        public byte Order { get; set; }
    }
}
