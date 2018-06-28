using NewsPortal.Domain.Entities.Common;
using NewsPortal.Domain.Entities.Users;

namespace NewsPortal.Domain.Entitites.Articles
{
    public class ArticleLike : CreatedDateEntity
    {
        public int ArticleId { get; set; }
        public int UserId { get; set; }
        public virtual Article Article { get; set; }
        public User User { get; set; }
    }
}
