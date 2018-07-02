using NewsPortal.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NewsPortal.Application.Roles.Dto
{
    public class RoleDto
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "The role name is required.")]
        [StringLength(Role.MaxNameLength)]
        public int Name { get; set; }
       
        [StringLength(Role.MaxDescriptionLength)]
        public int Description { get; set; }
         
        public UserType? UserType { get; set; }
    }
}
