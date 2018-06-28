using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace NewsPortal.Infrastructure.Data.EF.Mapping.User
{
    class RoleMap : IEntityTypeConfiguration<Domain.Entities.Users.Role>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Users.Role> builder)
        {
            // Primary Key
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Name)
                .HasMaxLength(64);

            builder.Property(t => t.Description)
                .HasMaxLength(256);

            // Table & Column Mappings
            builder.ToTable("Roles");
            builder.Property(t => t.Id).HasColumnName("Id");
            builder.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            builder.Property(t => t.UserId).HasColumnName("UserId");
            builder.Property(t => t.Name).HasColumnName("Name");
            builder.Property(t => t.Description).HasColumnName("Description");

        }
    }
}
