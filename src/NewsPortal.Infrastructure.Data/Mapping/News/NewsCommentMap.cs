
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewsPortal.Domain.Entitites.News;

namespace NewsPortal.Infrastructure.Data.Mapping.News
{
    public class NewsCommentMap : IEntityTypeConfiguration<NewsComment>
    {
        public void Configure(EntityTypeBuilder<NewsComment> builder)
        {
            // Primary Key
            builder.HasKey(t => t.Id);

            // Properties
            builder.Property(t => t.Comment)
                .IsRequired();

            // Table & Column Mappings
            builder.ToTable("NewsComments");
            builder.Property(t => t.Id).HasColumnName("Id");
            builder.Property(t => t.NewsId).HasColumnName("NewsId");
            builder.Property(t => t.UserId).HasColumnName("UserId");
            builder.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            builder.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            builder.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            builder.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            builder.Property(t => t.Comment).HasColumnName("Comment");

            // Relationships
            builder.HasOne(t => t.News)
                .WithMany(t => t.NewsComments)
                .HasForeignKey(d => d.NewsId);

        }
    }
}
