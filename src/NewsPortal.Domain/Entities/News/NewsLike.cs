using NewsPortal.Domain.Entities.Common;

namespace NewsPortal.Domain.Entitites.News
{
    public class NewsLike : Entity
    {
        public int NewsId { get; set; }
        public int UserId { get; set; }
        public virtual News News { get; set; }
    }
}
