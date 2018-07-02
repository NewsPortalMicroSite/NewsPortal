using NewsPortal.Domain.Entities.Common;
using NewsPortal.Infrastructure.CrossCutting.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NewsPortal.Domain.Entities.Users
{
    [Table("Roles")]
    public class Role : CreatedDateEntity
    {
        public const int MaxNameLength = 64;
        public const int MaxDescriptionLength = 256;

        public Role()
        {
            UserRoles = new HashSet<UserRoles>();
        }
          
        public int Name { get; set; }
        public int Description { get; set; }
        public bool SystemRole { get; protected set; }

        public ICollection<UserRoles> UserRoles { get; set; }

        public UserType? UserType { get; set; }
        public string UserTypeString
        {
            get { return UserType.ToString(); }
            set { UserType = ExtensionHelper.ParseEnum<UserType>(value); }
        }

       
       

       
        
    }
}
