using NewsPortal.Domain.Entities.Common;
using NewsPortal.Domain.Entitites.Articles;
using NewsPortal.Infrastructure.CrossCutting.Crypto;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace NewsPortal.Domain.Entities.Users
{
    [Table("Users")]
    public class User : AuditedEntity
    {
        public User()
        {
            ArticleComments = new HashSet<ArticleComment>();
            ArticleLikes = new HashSet<ArticleLike>();
            UserRoles = new HashSet<UserRoles>();
        }
        
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        public string PasswordResetCode { get; set; }
        public UserType UserType { get; set; }
        public ICollection<ArticleComment> ArticleComments { get; set; }
        public ICollection<ArticleLike> ArticleLikes { get; set; }
        public ICollection<UserRoles> UserRoles { get; set; }

        public string FullName() => string.Concat(FirstName, " ", LastName);

        public virtual IEnumerable<Role> Roles
        {
            get { return UserRoles.Select(q => q.Role).ToList(); }
        }


        public bool ValidatePassword(string password)
        {
            var hashedPassword = CryptoHelper.EncryptString(password);

            return (Password == hashedPassword);
        }
    }
}
