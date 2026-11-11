using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("SkillCards")]
    public class SkillCard
    {
        [Key] public Guid Id { get; set; }

        [Required]
        public string IconClass { get; set; } = string.Empty;

        [Required]
        [MaxLength(25)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string Description { get; set; } = string.Empty;

        public byte Order { get; set; }
    }
}
