using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NewsPortal.Data.Mapping.User
{
    public class UserMap : IEntityTypeConfiguration<Domain.Entities.User.User>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.User.User> builder)
        {
            // Primary Key
            builder.HasKey(t => t.Id);

        }
    }
}
