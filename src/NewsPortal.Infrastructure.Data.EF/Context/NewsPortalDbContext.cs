using Microsoft.EntityFrameworkCore;
using NewsPortal.Domain.Entities.Users;
using NewsPortal.Domain.Entitites.Articles;

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


        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<User> Users { get; set; }

        public DbSet<Article> Article { get; set; }
        public DbSet<ArticleComment> ArticleComment { get; set; }
        public DbSet<ArticleLike> ArticleLike { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArticleComment>(entity =>
            {
                entity.Property(e => e.Comment).HasMaxLength(256);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Article)
                    .WithMany(p => p.ArticleComments)
                    .HasForeignKey(d => d.ArticleId)
                    .HasConstraintName("FK_ArticleComments_Articles");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ArticleComments)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ArticleComments_Users");
            });

            modelBuilder.Entity<ArticleLike>(entity =>
            {
                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Article)
                    .WithMany(p => p.ArticleLikes)
                    .HasForeignKey(d => d.ArticleId)
                    .HasConstraintName("FK_ArticleLikes_Articles");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ArticleLikes)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ArticleLikes_Users");
            });

            modelBuilder.Entity<Article>(entity =>
            {
                entity.Property(e => e.ArticleType).HasMaxLength(128);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Picture).HasMaxLength(128);

                entity.Property(e => e.Published).HasDefaultValueSql("((0))");

                entity.Property(e => e.PublishedDate).HasColumnType("datetime");

                entity.Property(e => e.ShortContent).HasMaxLength(256);

                entity.Property(e => e.Tags).HasMaxLength(128);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.UserType).HasMaxLength(64);
            });

            modelBuilder.Entity<UserRoles>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.UserId });

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRoles_Roles");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRoles_Users");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FirstName).HasMaxLength(64);

                entity.Property(e => e.LastName).HasMaxLength(64);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.PasswordResetCode).HasMaxLength(128);

                entity.Property(e => e.UserType).HasMaxLength(128);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(64);
            });
        }

    }
}
