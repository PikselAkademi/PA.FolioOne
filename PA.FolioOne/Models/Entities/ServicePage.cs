using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("ServicePages")]
    public class ServicePage
    {
        [Key] public Guid Id { get; set; }

        [DisplayName("Sayfa Başlığı")]
        [Required(ErrorMessage = "Sayfa başlığı boş bırakılamaz.")]
        public string Title { get; set; } = string.Empty;

        [DisplayName("Sayfa Açıklaması")]
        [Required(ErrorMessage = "Sayfa açıklaması boş bırakılamaz.")]
        public string Description { get; set; } = string.Empty;
    }
}
