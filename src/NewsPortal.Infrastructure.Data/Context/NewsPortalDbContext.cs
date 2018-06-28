using Microsoft.EntityFrameworkCore;
using NewsPortal.Domain.Entities.Users;
using NewsPortal.Domain.Entitites.Articles;
using NewsPortal.Infrastructure.Data.Mapping.Article;
using NewsPortal.Infrastructure.Data.Mapping.User;
 

namespace NewsPortal.Infrastructure.Data.Context
{
    public class NewsPortalDbContext : DbContext
    {
        public NewsPortalDbContext(DbContextOptions<NewsPortalDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=.\\;Database=NewsPortal_Test;Trusted_Connection=True;");
            }
        }

        public DbSet<Article> Article { get; set; }
        public DbSet<ArticleComment> ArticleComment { get; set; }
        public DbSet<ArticleLike> ArticleLike { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            modelBuilder.ApplyConfiguration(new ArticleMap());
            modelBuilder.ApplyConfiguration(new ArticleCommentsMap());
            modelBuilder.ApplyConfiguration(new ArticleLikeMap());
            modelBuilder.ApplyConfiguration(new UserMap());
        }

    }
}
