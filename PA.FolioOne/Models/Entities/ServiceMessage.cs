using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("ServiceMessages")]
    public class ServiceMessage
    {
        [Key] public Guid Id { get; set; }

        [DisplayName("Ad Soyad")]
        [Required(ErrorMessage = "Ad soyad boş bırakılamaz.")]
        [MinLength(2, ErrorMessage = "Ad soyad en az 2 karakter olmalıdır.")]
        [DataType(DataType.Text)]
        public string FullName { get; set; } = string.Empty;

        [DisplayName("E-posta")]
        [Required(ErrorMessage = "E-posta boş bırakılamaz.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi girin.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;

        [DisplayName("Telefon Numarası")]
        [Required(ErrorMessage = "Telefon numarası boş bırakılamaz.")]
        [Phone(ErrorMessage = "Geçerli bir telefon numarası girin.")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; } = string.Empty;

        [DisplayName("Mesaj")]
        [Required(ErrorMessage = "Mesaj boş bırakılamaz.")]
        [MinLength(10, ErrorMessage = "Mesaj en az 10 karakter olmalıdır.")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; } = string.Empty;

        public DateTimeOffset SendedAt { get; set; } = DateTimeOffset.UtcNow;

        public bool IsRead { get; set; } = false;

        public Guid ServiceId { get; set; }

        [ForeignKey(nameof(ServiceId))]
        public Service? Service { get; set; }

    }
}
