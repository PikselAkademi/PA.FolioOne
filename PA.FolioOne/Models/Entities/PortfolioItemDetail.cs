using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("PortfolioItemDetails")]
    public class PortfolioItemDetail
    {
        [Key] public Guid Id { get; set; }

        [DisplayName("")]
        [Required]
        public string Title { get; set; } = string.Empty;

        [DisplayName("")]
        [Required]
        public string Description { get; set; } = string.Empty;

        //Tags
        public DateTime? PortfolioDate { get; set; }
        public string? Client { get; set; }
        [Url]
        public string? PortfolioUrl { get; set; }
        public string? Content { get; set; }
        public string? FeaturesTitle { get; set; }
        public string? Features { get; set; }

        public PortfolioItem? Item { get; set; }
    }
}
