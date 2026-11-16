using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("Testimonials")]
    public class Testimonial
    {
        [Key] public Guid Id { get; set; }

        [DisplayName("Yorum")]
        [Required(ErrorMessage = "Yorum zorunludur.")]
        public string Comment { get; set; } = string.Empty;

        [DisplayName("Yorumlayan Kişi")]
        [Required(ErrorMessage = "Yorumlayan kişi zorunludur.")]
        public string FullName { get; set; } = string.Empty;

        [DisplayName("Meslek")]
        public string? Title { get; set; }

        [ValidateNever] public string? ImageUrl { get; set; }
        [NotMapped] public IFormFile? ImageFile { get; set; }

        [DisplayName("Yorum Sırası")]
        public byte Order { get; set; }
    }
}
