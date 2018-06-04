﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NewsPortal.Data.Mapping.News
{
    public class NewsMap : IEntityTypeConfiguration<Domain.Entitites.News.News>
    {
        public void Configure(EntityTypeBuilder<Domain.Entitites.News.News> builder)
        {
            // Primary Key
            builder.HasKey(t => t.Id);

            // Properties
            builder.Property(t => t.Name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(128);

            builder.Property(t => t.Picture)
                .HasMaxLength(128);

            // Table & Column Mappings
            builder.ToTable("News");
            builder.Property(t => t.Id).HasColumnName("Id");
            builder.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            builder.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            builder.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            builder.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            builder.Property(t => t.Published).HasColumnName("Published");
            builder.Property(t => t.PublishingDate).HasColumnName("PublishingDate");
            builder.Property(t => t.Name).HasColumnName("Name");
            builder.Property(t => t.Picture).HasColumnName("Picture");
            builder.Property(t => t.LongContent).HasColumnName("LongContent");
            builder.Property(t => t.Tags).HasColumnName("Tags");
        }
    }
    

}
