
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewsPortal.Domain.Entitites.News;

namespace NewsPortal.Infrastructure.Data.Mapping.News
{
    public class NewsLikeMap : IEntityTypeConfiguration<NewsLike>
    {
        public void Configure(EntityTypeBuilder<NewsLike> builder)
        {
            // Primary Key
            builder.HasKey(t => t.Id);



            // Table & Column Mappings
            builder.ToTable("NewsLikes");
            builder.Property(t => t.Id).HasColumnName("Id");
            builder.Property(t => t.NewsId).HasColumnName("NewsId");
            builder.Property(t => t.UserId).HasColumnName("UserId");

            // Relationships
            builder.HasOne(t => t.News)
                .WithMany(t => t.NewsLikes)
                .HasForeignKey(d => d.NewsId);
        }
    }
}
