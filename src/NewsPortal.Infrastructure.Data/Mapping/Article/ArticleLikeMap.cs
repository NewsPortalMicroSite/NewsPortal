
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewsPortal.Domain.Entitites.Articles;

namespace NewsPortal.Infrastructure.Data.Mapping.Article
{
    public class ArticleLikeMap : IEntityTypeConfiguration<ArticleLike>
    {
        public void Configure(EntityTypeBuilder<ArticleLike> builder)
        {
            // Primary Key
            builder.HasKey(t => t.Id);

            builder.Property(t => t.CreatedDate).HasColumnName("CreatedDate").HasColumnType("datetime").HasDefaultValueSql("(getdate())");

            // Table & Column Mappings
            builder.ToTable("ArticleLikes");
            builder.Property(t => t.Id).HasColumnName("Id");
            builder.Property(t => t.ArticleId).HasColumnName("NewsId");
            builder.Property(t => t.UserId).HasColumnName("UserId");

            // Relationships
            builder.HasOne(t => t.Article)
                .WithMany(t => t.ArticleLikes)
                .HasForeignKey(d => d.ArticleId);

            builder.HasOne(d => d.Article)
                   .WithMany(p => p.ArticleLikes)
                   .HasForeignKey(d => d.ArticleId)
                   .HasConstraintName("FK_ArticleLikes_Articles");

            builder.HasOne(d => d.User)
                .WithMany(p => p.ArticleLikes)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_ArticleLikes_Users");
        }
    }
}
