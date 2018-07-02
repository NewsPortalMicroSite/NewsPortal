using NewsPortal.Domain.Entitites.Articles;
using NewsPortal.Infrastructure.Data.Context;
using NewsPortal.Infrastructure.Data.Repository.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPortal.Infrastructure.Data.EF.Repository
{
    public class ArticleCommentRepository : BaseRepository<ArticleComment>
    {
        public ArticleCommentRepository(NewsPortalDbContext dbContext) : base(dbContext)
        {

        }
    }
}
