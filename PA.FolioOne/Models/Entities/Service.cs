using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("Services")]
    public class Service
    {
        [Key] public Guid Id { get; set; }

        [DisplayName("İkon Sınıfı")]
        [Required(ErrorMessage = "İkon sınıfı boş bırakılamaz.")]
        public string IconClass { get; set; } = string.Empty;

        [DisplayName("Hizmet Başlığı")]
        [Required(ErrorMessage = "Hizmet başlığı boş bırakılamaz.")]
        public string Title { get; set; } = string.Empty;

        [DisplayName("Hizmet Açıklaması")]
        [Required(ErrorMessage = "Hizmet açıklaması boş bırakılamaz.")]
        public string Description { get; set; } = string.Empty;

        [DisplayName("Hizmet Sırası")]
        public byte Order { get; set; }

        public ServiceDetail? Detail { get; set; }

        [Required(ErrorMessage = "Hizmet kategorisi boş bırakılamaz.")]
        public Guid CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public ServiceCategory? Category { get; set; }

        public List<ServiceBenefitCard>? Benefits { get; set; }

        public List<ServiceTimeline>? Timelines { get; set; }

        public List<ServiceMessage>? Messages { get; set; }

    }
}
