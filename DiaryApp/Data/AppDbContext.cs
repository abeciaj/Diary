using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace DiaryApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Models.DiaryEntryModel> DiaryEntries { get; set; }
    }
}
