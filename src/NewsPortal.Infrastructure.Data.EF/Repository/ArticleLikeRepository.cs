using NewsPortal.Domain.Entitites.Articles;
using NewsPortal.Domain.Interfaces.Repositories;
using NewsPortal.Infrastructure.Data.Context;
using NewsPortal.Infrastructure.Data.Repository.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPortal.Infrastructure.Data.EF.Repository
{
    public class ArticleLikeRepository  : BaseRepository<ArticleLike>, IArticleLikeRepository
    {
        public ArticleLikeRepository(NewsPortalDbContext dbContext) : base(dbContext)
        {

        }
    }
}
