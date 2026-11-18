using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("PortfolioTags")]
    public class PortfolioTag
    {
        [Key] public Guid Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public List<PortfolioItem>? Items { get; set; }
    }
}
