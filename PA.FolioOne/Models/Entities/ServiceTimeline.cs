using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("ServiceTimelines")]
    public class ServiceTimeline
    {
        [Key] public Guid Id { get; set; }

        [DisplayName("Başlık")]
        [Required(ErrorMessage = "Başlık boş bırakılamaz.")]
        public string Title { get; set; } = string.Empty;

        [DisplayName("Açıklama")]
        public string? Description { get; set; }

        [DisplayName("Alt Metin")]
        public string? Subtitle { get; set; }

        [DisplayName("Sıra")]
        public byte Order { get; set; }

        public Guid ServiceId { get; set; }

        [ForeignKey(nameof(ServiceId))]
        public Service? Service { get; set; }
    }
}
