
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewsPortal.Domain.Entitites.Articles;

namespace NewsPortal.Infrastructure.Data.Mapping.Article
{
    public class ArticleCommentsMap : IEntityTypeConfiguration<ArticleComment>
    {
        public void Configure(EntityTypeBuilder<ArticleComment> builder)
        {
            // Primary Key
            builder.HasKey(t => t.Id);

            // Properties
            builder.Property(t => t.Comment)
                .IsRequired();

            // Table & Column Mappings
            builder.ToTable("ArticleComments");
            builder.Property(t => t.Id).HasColumnName("Id");
            builder.Property(t => t.ArticleId).HasColumnName("ArticleId");
            builder.Property(t => t.UserId).HasColumnName("UserId");

            builder.Property(t => t.CreatedDate).HasColumnName("CreatedDate").HasColumnType("datetime").HasDefaultValueSql("(getdate())");

            builder.Property(t => t.Comment).HasColumnName("Comment").HasMaxLength(256);
            
            // Relationships
            builder.HasOne(t => t.Article)
                .WithMany(t => t.ArticleComments)
                .HasForeignKey(d => d.ArticleId)
                .HasConstraintName("FK_ArticleComments_Articles");

            builder.HasOne(d => d.User)
                    .WithMany(p => p.ArticleComments)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ArticleComments_Users");

        }
    }
}
