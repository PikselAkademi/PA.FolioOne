using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("PortfolioCategories")]
    public class PortfolioCategory
    {
        [Key] public Guid Id { get; set; }

        [DisplayName("")]
        [Required]
        public string Title { get; set; } = string.Empty;

        [DisplayName("")]
        [Required]
        public string FilterClass { get; set; } = string.Empty;

        public List<PortfolioItem>? Items { get; set; }
    }
}
