using NewsPortal.Domain.Entities.Common;
using System;
using System.Collections.Generic;
 

namespace NewsPortal.Domain.Entitites.News
{
    public class News : AuditedEntity
    {
        public bool Published { get; set; }
        public DateTime? PublishingDate { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string ShortContent { get; set; }
        public string LongContent { get; set; }
        public string Tags { get; set; }
        public virtual ICollection<NewsComment> NewsComments { get; set; }
        public virtual ICollection<NewsLike> NewsLikes { get; set; }
    }
}
