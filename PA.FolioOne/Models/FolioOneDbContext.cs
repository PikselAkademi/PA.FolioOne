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
        public DbSet<AboutPage> AboutPages { get; set; }
        public DbSet<SkillCard> SkillCards { get; set; }
        public DbSet<TimeLine> TimeLines { get; set; }

        //Other Configurations
    }
}
