using NewsPortal.Application.Dto;
using NewsPortal.Application.Roles.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewsPortal.Application.Roles
{
    public interface IRoleAppService
    {
        Task<RoleDto> Get(IEntityDto<int> input);

        Task<ListRoleDto> GetAll(PagingCommand input);

        Task<RoleDto> Create(CreateRoleDto input);

        Task<RoleDto> Update(RoleDto input);

        Task Delete(IEntityDto<int> input);
    }
}
