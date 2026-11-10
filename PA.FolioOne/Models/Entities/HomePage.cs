using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("HomePages")]
    public class HomePage
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Ana sayfa başlığı zorunludur.")]
        [MaxLength(100, ErrorMessage = "Ana sayfa başlığı en fazla 100 karakter olabilir.")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Ana sayfa anahtar kelimeleri zorunludur.")]
        public string Keywords { get; set; } = string.Empty;

        [Required(ErrorMessage = "Ana sayfa açıklaması zorunludur.")]
        [MinLength(15, ErrorMessage = "Ana sayfa açıklaması en az 15 karakter olmalıdır.")]
        [MaxLength(350, ErrorMessage = "Ana sayfa açıklaması en fazla 350 karakter olabilir.")]
        [DataType(DataType.MultilineText, ErrorMessage = "Veri tipi hatalı!")]
        public string Description { get; set; } = string.Empty;

        public string? LeftButtonText { get; set; }
        [Url(ErrorMessage = "Geçerli bir URL giriniz.")]
        public string? LeftButtonUrl { get; set; }

        [DisplayName("Sağ Buton Metni")]
        public string? RightButtonText { get; set; }
        [Url(ErrorMessage = "Geçerli bir URL giriniz.")]
        public string? RightButtonUrl { get; set; }

        public bool ShowSocialLinks { get; set; } = true;

        [ValidateNever]
        public string? ImageUrl { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }

        public string? FloatingItem1Text { get; set; }
        public string? FloatingItem1IconClass { get; set; }

        public string? FloatingItem2Text { get; set; }
        public string? FloatingItem2IconClass { get; set; }

        public string? FloatingItem3Text { get; set; }
        public string? FloatingItem3IconClass { get; set; }

    }
}
