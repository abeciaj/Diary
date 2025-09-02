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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Models.DiaryEntryModel>()
                .HasData(
                    new Models.DiaryEntryModel
                    {
                        EntryId = 1,
                        Title = "Welcome to Your Diary",
                        Content = "This is your first diary entry. Feel free to edit or delete it.",
                        CreatedAt = DateTime.Now
                    },
                    new Models.DiaryEntryModel
                    {
                        EntryId = 2,
                        Title = "Getting Started",
                        Content = "Start writing your thoughts and experiences here. Your diary is a safe space.",
                        CreatedAt = DateTime.Now
                    }
                );
        }
    }
}
