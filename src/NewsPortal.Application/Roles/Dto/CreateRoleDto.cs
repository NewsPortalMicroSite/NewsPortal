using NewsPortal.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations;

namespace NewsPortal.Application.Roles.Dto
{

    public class CreateRoleDto
    {
        public int UserId { get; set; }

        [Required]
        [StringLength(Role.MaxNameLength)]
        public int Name { get; set; }

        [StringLength(Role.MaxDescriptionLength)]
        public int Description { get; set; }

    }
}
