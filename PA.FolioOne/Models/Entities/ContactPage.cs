using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PA.FolioOne.Models.Entities
{
    [Table("ContactPages")]
    public class ContactPage
    {
        [Key] public Guid Id { get; set; }

        public string PageTitle { get; set; } = string.Empty;
        public string PageDescription { get; set; } = string.Empty;

        public string ContactTitle { get; set; } = string.Empty;
        public string ContactDescription { get; set; } = string.Empty;

        public string FormTitle { get; set; } = string.Empty;
        public string FormDescription { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
    }
}

