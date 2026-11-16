using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("SkillCards")]
    public class SkillCard
    {
        [DisplayName("Kimlik")]
        [Key] public Guid Id { get; set; }

        [DisplayName("İkon Sınıfı")]
        [Required(ErrorMessage = "İkon sınıfı zorunludur.")]
        public string IconClass { get; set; } = string.Empty;

        [DisplayName("Ad")]
        [Required(ErrorMessage = "Ad alanı zorunludur.")]
        [MaxLength(25, ErrorMessage = "Ad en fazla 25 karakter olabilir.")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("Açıklama")]
        [Required(ErrorMessage = "Açıklama alanı zorunludur.")]
        [MaxLength(100, ErrorMessage = "Açıklama en fazla 100 karakter olabilir.")]
        public string Description { get; set; } = string.Empty;

        [DisplayName("Sıra")]
        public byte Order { get; set; }
    }
}
