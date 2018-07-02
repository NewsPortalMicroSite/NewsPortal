using NewsPortal.Domain.Entities.Users;
using NewsPortal.Domain.Interfaces.Repositories;
using NewsPortal.Infrastructure.Data.Context;
using NewsPortal.Infrastructure.Data.Repository.Common;

namespace NewsPortal.Infrastructure.Data.EF.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(NewsPortalDbContext dbContext) : base(dbContext)
        {

        }
    }
}
