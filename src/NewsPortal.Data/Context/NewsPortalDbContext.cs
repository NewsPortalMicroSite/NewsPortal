
using Microsoft.EntityFrameworkCore;
using NewsPortal.Data.Mapping.News;
using NewsPortal.Data.Mapping.User;
using NewsPortal.Domain.Entitites.News;

namespace NewsPortal.Data.Context
{
    public class NewsPortalDbContext : DbContext
    {
        public NewsPortalDbContext(DbContextOptions<NewsPortalDbContext> options) : base(options) { }
         
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("connectionstring");
            }
        }
         
        public DbSet<News> News { get; set; }
        public DbSet<NewsComment> NewsComment { get; set; }
        public DbSet<NewsLike> NewsLike { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new NewsMap());
            modelBuilder.ApplyConfiguration(new NewsCommentMap());
            modelBuilder.ApplyConfiguration(new NewsLikeMap());

            modelBuilder.ApplyConfiguration(new UserMap()); 
        }
    }

}
