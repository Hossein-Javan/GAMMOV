using Microsoft.EntityFrameworkCore;
using GAMMOV.DataLayer.Entities;

namespace GAMMOV.DataLayer.Context
{
    public class GAMMOVContext:DbContext
    {
        public GAMMOVContext(DbContextOptions<GAMMOVContext> options) : base(options)
        {

        }

        public DbSet<Ads> Ads { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<SeoData> SeoData { get; set; }
        public DbSet<SiteSetting> SiteSettings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SocialMedia> SocialMedia { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // تنظیم رفتار حذف کاسکید به Restrict برای تمام کلیدهای خارجی
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}
