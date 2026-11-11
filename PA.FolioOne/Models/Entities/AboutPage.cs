using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("AboutPages")]
    public class AboutPage
    {
        [Key] public Guid Id { get; set; }

        //Sayfa Giriş Alanı
        [Required] public string PageTitle { get; set; } = string.Empty;
        [Required] public string PageDescription { get; set; } = string.Empty;

        //Hakkımızda Alanı
        [Required] public string UpperTitle { get; set; } = string.Empty;
        [Required] public string Title { get; set; } = string.Empty;
        [Required] public string Description { get; set; } = string.Empty;

        public string? LeftButtonText { get; set; }
        [Url] public string? LeftButtonUrl { get; set; }

        public string? RightButtonText { get; set; }
        [ValidateNever] public string? RightButtonUrl { get; set; }
        [NotMapped] public IFormFile? RightButtonFile { get; set; }

        [ValidateNever] public string? ImageUrl { get; set; }
        [NotMapped] public IFormFile? ImageFile { get; set; }

        [NotMapped] public List<SkillCard>? SkillCards { get; set; }
        public bool ShowSkillCards { get; set; }

        [NotMapped] public List<TimeLine>? TimeLines { get; set; }
        public bool ShowTimeLine { get; set; }

        public string? BadgeTitle { get; set; }
        //About Badges
        public bool ShowBadges { get; set; }

        public string? SkillTitle { get; set; }
        public string? SkillDescription { get; set; }
        //Skills
        public bool ShowSkills { get; set; }

        public short Stat1Value { get; set; }
        public char? Stat1Symbol { get; set; }
        public string? Stat1Title { get; set; }

        public short Stat2Value { get; set; }
        public char? Stat2Symbol { get; set; }
        public string? Stat2Title { get; set; }

        public short Stat3Value { get; set; }
        public char? Stat3Symbol { get; set; }
        public string? Stat3Title { get; set; }

        public bool ShowStats { get; set; }

        public string? TestimonialTitle { get; set; }
        public string? TestimonialDescription { get; set; }
        //Testimonial
        public bool ShowTestimonials { get; set; }
    }
}
