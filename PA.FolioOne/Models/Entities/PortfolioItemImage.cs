using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("PortfolioItemImages")]
    public class PortfolioItemImage
    {
        [Key] public Guid Id { get; set; }

        [ValidateNever] public string? ImageUrl { get; set; }

        public string? ImageAlt { get; set; }

        public byte Order { get; set; }

        public Guid ItemId { get; set; }

        [ForeignKey(nameof(ItemId))]
        public PortfolioItem? Item { get; set; }
    }
}
