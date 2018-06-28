using NewsPortal.Domain.Entities.Common;
using NewsPortal.Domain.Entitites.Articles;
using System.Collections.Generic;

namespace NewsPortal.Domain.Entities.Users
{
    public class User : AuditedEntity
    {
        public User()
        {
            ArticleComments = new HashSet<ArticleComment>();
            ArticleLikes = new HashSet<ArticleLike>();
        }
        
        public string Username { get; set; }
        public string Password { get; set; }
        public string NameSurname { get; set; }
        public Role Role { get; set; }

        public ICollection<ArticleComment> ArticleComments { get; set; }
        public ICollection<ArticleLike> ArticleLikes { get; set; }
    }
}
