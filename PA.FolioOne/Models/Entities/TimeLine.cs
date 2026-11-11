using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("TimeLines")]
    public class TimeLine
    {
        [Key] public Guid Id { get; set; }

        [Required]
        public DateOnly Date { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(150)]
        public string Description { get; set; } = string.Empty;

    }
}
