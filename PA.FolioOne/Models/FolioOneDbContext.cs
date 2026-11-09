using Microsoft.EntityFrameworkCore;

namespace PA.FolioOne.Models
{
    public class FolioOneDbContext : DbContext
    {
#if DEBUG
        public FolioOneDbContext() { }
#endif

        public FolioOneDbContext(DbContextOptions<FolioOneDbContext> options)
            : base(options) { }

        //Tables

        //Other Configurations
    }
}
