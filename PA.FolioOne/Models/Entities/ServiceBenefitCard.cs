using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("ServiceBenefitCards")]
    public class ServiceBenefitCard
    {
        [Key] public Guid Id { get; set; }

        [DisplayName("İkon Sınıfı")]
        [Required(ErrorMessage = "İkon sınıfı boş bırakılamaz.")]
        public string IconClass { get; set; } = string.Empty;

        [DisplayName("Başlık")]
        [Required(ErrorMessage = "Başlık boş bırakılamaz.")]
        public string Title { get; set; } = string.Empty;

        [DisplayName("Açıklama")]
        [Required(ErrorMessage = "Açıklama boş bırakılamaz.")]
        public string Description { get; set; } = string.Empty;

        [DisplayName("Sıra")]
        public byte Order { get; set; }

        public Guid ServiceId { get; set; }

        [ForeignKey(nameof(ServiceId))]
        public Service? Service { get; set; }
    }
}
