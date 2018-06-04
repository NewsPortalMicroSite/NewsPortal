using NewsPortal.Domain.Entities.Common; 

namespace NewsPortal.Domain.Entitites.News
{
    public class NewsComment : AuditedEntity
    {
        public int NewsId { get; set; }
        public int UserId { get; set; }
        public string Comment { get; set; }
        public virtual News News { get; set; }

    }
}
