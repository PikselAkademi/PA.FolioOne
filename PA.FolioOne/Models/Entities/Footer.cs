using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Telif hakkı bilgisi zorunludur.")]
        [MaxLength(150, ErrorMessage = "Telif hakkı bilgisi en fazla 150 karakter olabilir.")]
        public string Copyright { get; set; } = string.Empty;

        [MaxLength(75, ErrorMessage = "Kredi metni en fazla 75 karakter olabilir.")]
        public string? CreditText { get; set; }

        [Url(ErrorMessage = "Geçerli bir URL girin.")]
        public string? CreditLink { get; set; }
    }
}
