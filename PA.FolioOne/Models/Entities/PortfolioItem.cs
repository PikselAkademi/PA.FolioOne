using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("PortfolioItems")]
    public class PortfolioItem
    {
        [Key] public Guid Id { get; set; }

        [ValidateNever] public string? ImageUrl { get; set; }

        [DisplayName("")]
        [Required]
        public string Title { get; set; } = string.Empty;

        [DisplayName("")]
        [Required]
        public string Subtitle { get; set; } = string.Empty;

        public Guid CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public PortfolioCategory? Category { get; set; }

        public PortfolioItemDetail? Detail { get; set; }

        public List<PortfolioItemImage>? Images { get; set; }
        public List<PortfolioItemCard>? Cards { get; set; }

        public List<PortfolioTag>? Tags { get; set; }
    }
}
