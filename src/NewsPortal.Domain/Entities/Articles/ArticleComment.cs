using NewsPortal.Domain.Entities.Common;
using NewsPortal.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsPortal.Domain.Entitites.Articles
{
    [Table("ArticleComments")]
    public class ArticleComment  : CreatedDateEntity
    {
       
        public int ArticleId { get; set; }
        public int UserId { get; set; }
        public string Comment { get; set; }
        public virtual Article Article { get; set; }
        public virtual User User { get; set; }
    }
}
