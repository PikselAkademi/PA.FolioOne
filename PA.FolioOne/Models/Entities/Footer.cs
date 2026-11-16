using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("Footers")]
    public class Footer
    {
        [DisplayName("Kimlik")]
        [Key]
        public Guid Id { get; set; }

        [DisplayName("Telif Hakkı")]
        [Required(ErrorMessage = "Telif hakkı bilgisi zorunludur.")]
        [MaxLength(150, ErrorMessage = "Telif hakkı bilgisi en fazla 150 karakter olabilir.")]
        public string Copyright { get; set; } = string.Empty;

        [DisplayName("Kredi Metni")]
        [MaxLength(75, ErrorMessage = "Kredi metni en fazla 75 karakter olabilir.")]
        public string? CreditText { get; set; }

        [DisplayName("Kredi Linki")]
        [Url(ErrorMessage = "Geçerli bir URL girin.")]
        public string? CreditLink { get; set; }
    }
}
