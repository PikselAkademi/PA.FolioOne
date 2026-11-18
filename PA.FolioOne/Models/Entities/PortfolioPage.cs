using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("PortfolioPages")]
    public class PortfolioPage
    {
        [Key] public Guid Id { get; set; }

        [DisplayName("")]
        [Required]
        public string Title { get; set; } = string.Empty;

        [DisplayName("")]
        [Required]
        public string Description { get; set; } = string.Empty;
    }
}
