using NewsPortal.Domain.Entities.Common;
using NewsPortal.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsPortal.Domain.Entitites.Articles
{
    [Table("ArticleLikes")]
    public class ArticleLike : CreatedDateEntity
    {
        public int ArticleId { get; set; }
        public int UserId { get; set; }
        public Article Article { get; set; }
        public User User { get; set; }
    }
}
