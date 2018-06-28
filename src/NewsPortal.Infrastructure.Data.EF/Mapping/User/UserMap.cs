using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NewsPortal.Infrastructure.Data.EF.Mapping.User
{
    public class UserMap : IEntityTypeConfiguration<Domain.Entities.Users.User>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Users.User> builder)
        {
            // Primary Key
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Username)
                .HasMaxLength(64);
            builder.Property(t => t.Password)
              .HasMaxLength(64);
            builder.Property(t => t.NameSurname)
              .HasMaxLength(128);

            // Table & Column Mappings
            builder.ToTable("Users");
            builder.Property(t => t.Id).HasColumnName("Id");
            builder.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            builder.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            builder.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            builder.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            builder.Property(t => t.Username).HasColumnName("Username");
            builder.Property(t => t.Password).HasColumnName("Password");
            builder.Property(t => t.NameSurname).HasColumnName("NameSurname");

        }
    }
}
