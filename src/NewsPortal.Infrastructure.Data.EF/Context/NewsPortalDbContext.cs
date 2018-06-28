using Microsoft.EntityFrameworkCore;
using NewsPortal.Domain.Entities.Users;
using NewsPortal.Domain.Entitites.Articles;
using NewsPortal.Infrastructure.Data.EF.Mapping.User;
using NewsPortal.Infrastructure.Data.EF.Mapping.Article; 
 

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


        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public DbSet<Article> Article { get; set; }
        public DbSet<ArticleComment> ArticleComment { get; set; }
        public DbSet<ArticleLike> ArticleLike { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new RoleMap());
            modelBuilder.ApplyConfiguration(new ArticleMap());
            modelBuilder.ApplyConfiguration(new ArticleCommentsMap());
            modelBuilder.ApplyConfiguration(new ArticleLikeMap());
            
        }

    }
}
