using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("ContactMessages")]
    public class ContactMessage
    {
        [Key] public Guid Id { get; set; }

        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;

        public bool IsReaded { get; set; } = false;

        public DateTimeOffset SendedAt { get; set; } = DateTimeOffset.UtcNow;
    }
}
