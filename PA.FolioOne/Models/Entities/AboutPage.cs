using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("AboutPages")]
    public class AboutPage
    {
        [DisplayName("Kimlik")]
        [Key] public Guid Id { get; set; }

        //Sayfa Giriş Alanı
        [DisplayName("Sayfa Başlığı")]
        [Required(ErrorMessage = "Sayfa başlığı zorunludur.")] public string PageTitle { get; set; } = string.Empty;
        [DisplayName("Sayfa Açıklaması")]
        [Required(ErrorMessage = "Sayfa açıklaması zorunludur.")] public string PageDescription { get; set; } = string.Empty;

        //Hakkımızda Alanı
        [DisplayName("Üst Başlık")]
        [Required(ErrorMessage = "Üst başlık zorunludur.")] public string UpperTitle { get; set; } = string.Empty;
        [DisplayName("Başlık")]
        [Required(ErrorMessage = "Başlık zorunludur.")] public string Title { get; set; } = string.Empty;
        [DisplayName("Açıklama")]
        [Required(ErrorMessage = "Açıklama zorunludur.")] public string Description { get; set; } = string.Empty;

        [DisplayName("Sol Buton Metni")]
        public string? LeftButtonText { get; set; }
        [DisplayName("Sol Buton URL")]
        [Url(ErrorMessage = "Geçerli bir URL giriniz.")] public string? LeftButtonUrl { get; set; }

        [DisplayName("Sağ Buton Metni")]
        public string? RightButtonText { get; set; }
        [DisplayName("Sağ Buton URL")]
        [ValidateNever] public string? RightButtonUrl { get; set; }
        [DisplayName("Sağ Buton Dosyası")]
        [NotMapped] public IFormFile? RightButtonFile { get; set; }

        [DisplayName("Görsel URL")]
        [ValidateNever] public string? ImageUrl { get; set; }
        [DisplayName("Görsel Dosyası")]
        [NotMapped] public IFormFile? ImageFile { get; set; }

        [DisplayName("Yetenek Kartları")]
        [NotMapped] public List<SkillCard>? SkillCards { get; set; }
        [DisplayName("Yetenek Kartlarını Göster")]
        public bool ShowSkillCards { get; set; }

        [DisplayName("Zaman Çizelgeleri")]
        [NotMapped] public List<TimeLine>? TimeLines { get; set; }
        [DisplayName("Zaman Çizelgesini Göster")]
        public bool ShowTimeLine { get; set; }

        [DisplayName("Rozet Başlığı")]
        public string? BadgeTitle { get; set; }
        [NotMapped] public List<AboutBadge>? AboutBadges { get; set; }
        [DisplayName("Rozetleri Göster")]
        public bool ShowBadges { get; set; }

        [DisplayName("Yetenek Başlığı")]
        public string? SkillTitle { get; set; }
        [DisplayName("Yetenek Açıklaması")]
        public string? SkillDescription { get; set; }
        [NotMapped] public List<Skill>? Skills { get; set; }
        [DisplayName("Yetenekleri Göster")]
        public bool ShowSkills { get; set; }

        [DisplayName("İstatistik 1 Değeri")]
        public short Stat1Value { get; set; }
        [DisplayName("İstatistik 1 Simgesi")]
        public char? Stat1Symbol { get; set; }
        [DisplayName("İstatistik 1 Başlığı")]
        public string? Stat1Title { get; set; }

        [DisplayName("İstatistik 2 Değeri")]
        public short Stat2Value { get; set; }
        [DisplayName("İstatistik 2 Simgesi")]
        public char? Stat2Symbol { get; set; }
        [DisplayName("İstatistik 2 Başlığı")]
        public string? Stat2Title { get; set; }

        [DisplayName("İstatistik 3 Değeri")]
        public short Stat3Value { get; set; }
        [DisplayName("İstatistik 3 Simgesi")]
        public char? Stat3Symbol { get; set; }
        [DisplayName("İstatistik 3 Başlığı")]
        public string? Stat3Title { get; set; }

        [DisplayName("İstatistikleri Göster")]
        public bool ShowStats { get; set; }

        [DisplayName("Referans Başlığı")]
        public string? TestimonialTitle { get; set; }
        [DisplayName("Referans Açıklaması")]
        public string? TestimonialDescription { get; set; }
        [NotMapped] public List<Testimonial>? Testimonials { get; set; }
        [DisplayName("Referansları Göster")]
        public bool ShowTestimonials { get; set; }
    }
}
