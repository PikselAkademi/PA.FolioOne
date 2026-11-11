using Microsoft.EntityFrameworkCore;
using PA.FolioOne.Models.Entities;

namespace PA.FolioOne.Models
{
    public class FolioOneDbContext : DbContext
    {
#if DEBUG
        public FolioOneDbContext() { }
#endif

        public FolioOneDbContext(DbContextOptions<FolioOneDbContext> options)
            : base(options) { }

        public DbSet<SocialLink> SocialLinks { get; set; }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<HomePage> HomePages { get; set; }

        //Other Configurations
    }
}
