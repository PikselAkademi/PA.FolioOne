using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("AboutPages")]
    public class AboutPage
    {
        [Key]
        public Guid Id { get; set; }

        //Sayfa Giriş Alanı
        [Required] public string PageTitle { get; set; } = string.Empty;
        [Required] public string PageDescription { get; set; } = string.Empty;

        //Hakkımızda Alanı
        [Required] public string UpperTitle { get; set; } = string.Empty;
        [Required] public string Title { get; set; } = string.Empty;
        [Required] public string Description { get; set; } = string.Empty;
    }
}
