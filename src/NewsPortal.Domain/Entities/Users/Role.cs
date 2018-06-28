using NewsPortal.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPortal.Domain.Entities.Users
{
    public class Role : CreatedDateEntity
    {
        public int UserId { get; set; }
        public int Name { get; set; }
        public int Description { get; set; }
        public virtual User User { get; set; }
    }
}
