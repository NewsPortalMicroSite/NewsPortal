using System;

namespace NewsPortal.Domain.Entities.Common
{
    public class AuditedEntity : Entity
    {
        public AuditedEntity()
        {
            CreatedDate = DateTime.Now;
        }

        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
