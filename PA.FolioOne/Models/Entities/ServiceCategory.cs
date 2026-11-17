using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("ServiceCategories")]
    public class ServiceCategory
    {
        [Key] public Guid Id { get; set; }

        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage = "Kategori adı boş bırakılamaz.")]
        public string Name { get; set; } = string.Empty;

        public List<Service>? Services { get; set; }
    }
}
