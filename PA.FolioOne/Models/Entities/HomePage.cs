using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("HomePages")]
    public class HomePage
    {
        [DisplayName("Kimlik")]
        [Key]
        public Guid Id { get; set; }

        [DisplayName("Başlık")]
        [Required(ErrorMessage = "Ana sayfa başlığı zorunludur.")]
        [MaxLength(100, ErrorMessage = "Ana sayfa başlığı en fazla 100 karakter olabilir.")]
        public string Title { get; set; } = string.Empty;

        [DisplayName("Anahtar Kelimeler")]
        [Required(ErrorMessage = "Ana sayfa anahtar kelimeleri zorunludur.")]
        public string Keywords { get; set; } = string.Empty;

        [DisplayName("Açıklama")]
        [Required(ErrorMessage = "Ana sayfa açıklaması zorunludur.")]
        [MinLength(15, ErrorMessage = "Ana sayfa açıklaması en az 15 karakter olmalıdır.")]
        [MaxLength(350, ErrorMessage = "Ana sayfa açıklaması en fazla 350 karakter olabilir.")]
        [DataType(DataType.MultilineText, ErrorMessage = "Veri tipi hatalı!")]
        public string Description { get; set; } = string.Empty;

        [DisplayName("Sol Buton Metni")]
        public string? LeftButtonText { get; set; }
        [DisplayName("Sol Buton URL")]
        [Url(ErrorMessage = "Geçerli bir URL giriniz.")]
        public string? LeftButtonUrl { get; set; }

        [DisplayName("Sağ Buton Metni")]
        public string? RightButtonText { get; set; }
        [DisplayName("Sağ Buton URL")]
        [Url(ErrorMessage = "Geçerli bir URL giriniz.")]
        public string? RightButtonUrl { get; set; }

        [DisplayName("Sosyal Linkleri Göster")]
        public bool ShowSocialLinks { get; set; } = true;

        [DisplayName("Görsel URL")]
        [ValidateNever]
        public string? ImageUrl { get; set; }

        [DisplayName("Görsel Dosyası")]
        [NotMapped]
        public IFormFile? ImageFile { get; set; }

        [DisplayName("Yüzen Öğe 1 Metni")]
        public string? FloatingItem1Text { get; set; }
        [DisplayName("Yüzen Öğe 1 İkon Sınıfı")]
        public string? FloatingItem1IconClass { get; set; }

        [DisplayName("Yüzen Öğe 2 Metni")]
        public string? FloatingItem2Text { get; set; }
        [DisplayName("Yüzen Öğe 2 İkon Sınıfı")]
        public string? FloatingItem2IconClass { get; set; }

        [DisplayName("Yüzen Öğe 3 Metni")]
        public string? FloatingItem3Text { get; set; }
        [DisplayName("Yüzen Öğe 3 İkon Sınıfı")]
        public string? FloatingItem3IconClass { get; set; }

    }
}
