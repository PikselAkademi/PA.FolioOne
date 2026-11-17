using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("ServiceDetails")]
    public class ServiceDetail
    {
        [Key, ForeignKey(nameof(Service))]
        public Guid Id { get; set; }

        public Service? Service { get; set; }

        [DisplayName("Okuma Süresi")]
        public byte ReadMinutes { get; set; }

        [ValidateNever] public string? ImageUrl { get; set; }

        [DisplayName("Editör İçeriği")]
        [Required(ErrorMessage = "Editör içeriği boş bırakılamaz.")]
        public string EditorContent { get; set; } = string.Empty;

        [DisplayName("Zaman Çizelgesi Başlığı")]
        public string? TimelineTitle { get; set; }

        [DisplayName("Zaman Çizelgesini Göster")]
        public bool IsTimelineVisible { get; set; } = false;

        [DisplayName("Form Başlığı")]
        [Required(ErrorMessage = "Form başlığı boş bırakılamaz.")]
        public string FormTitle { get; set; } = string.Empty;

        [DisplayName("Form Açıklaması")]
        [Required(ErrorMessage = "Form açıklaması boş bırakılamaz.")]
        public string FormDescription { get; set; } = string.Empty;
    }
}
