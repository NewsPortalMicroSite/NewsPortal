using NewsPortal.Domain.Entities.Common;

namespace NewsPortal.Domain.Entities.User
{
    public class User : AuditedEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string NameSurname { get; set; }
        public Role Role { get; set; } 
    }
}
