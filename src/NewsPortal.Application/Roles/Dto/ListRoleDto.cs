using NewsPortal.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPortal.Application.Roles.Dto
{
    public class ListRoleDto
    {
        public IEnumerable<RoleSummary> Roles { get; set; }
        public class RoleSummary
        {
            public int UserId { get; set; }

            public int Name { get; set; }

            public int Description { get; set; }

            public UserType? UserType { get; set; }
        }
    }
}
