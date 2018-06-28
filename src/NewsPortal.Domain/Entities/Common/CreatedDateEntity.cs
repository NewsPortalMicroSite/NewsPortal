using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPortal.Domain.Entities.Common
{
    public class CreatedDateEntity : Entity
    {
        public CreatedDateEntity()
        {
            CreatedDate = new DateTime();
        }

        public DateTime CreatedDate { get; set; }
    }
}
