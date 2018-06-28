using NewsPortal.Domain.Entitites.Articles;
using NewsPortal.Domain.Interfaces.Repositories;
using NewsPortal.Infrastructure.Data.Context;
using NewsPortal.Infrastructure.Data.Repository.Common;
 

namespace NewsPortal.Infrastructure.Data.Repository.News
{
    public class ArticleRepository  : BaseRepository<Article>, IArticleRepository
    {
        public ArticleRepository(NewsPortalDbContext dbContext) : base(dbContext)
        {

        }
    }
}
