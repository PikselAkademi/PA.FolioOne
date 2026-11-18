using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("PortfolioItemCards")]
    public class PortfolioItemCard
    {
        [Key] public Guid Id { get; set; }

        [Required]
        public string IconClass { get; set; } = string.Empty;

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;

        public byte Order { get; set; }

        public Guid ItemId { get; set; }

        [ForeignKey(nameof(ItemId))]
        public PortfolioItem? Item { get; set; }
    }
}
