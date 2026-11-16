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
        public DbSet<AboutBadge> AboutBadges { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<ResumePage> ResumePages { get; set; }
        public DbSet<ResumeCategory> ResumeCategories { get; set; }
        public DbSet<ResumeItem> ResumeItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<ResumeCategory>()
            //    .HasMany(x => x.Items)
            //    .WithOne(x => x.Category)
            //    .HasForeignKey(x => x.CategoryId);

            modelBuilder.Entity<ResumeItem>()
                .HasOne(x => x.Category)
                .WithMany(x => x.Items)
                .HasForeignKey(x => x.CategoryId);



            base.OnModelCreating(modelBuilder);
        }
    }
}
