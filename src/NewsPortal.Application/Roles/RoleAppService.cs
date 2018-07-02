using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NewsPortal.Application.Dto;
using NewsPortal.Application.Roles.Dto;
using NewsPortal.Domain.Interfaces.Repositories;

namespace NewsPortal.Application.Roles
{
    public class RoleAppService : IRoleAppService
    {
        IRoleRepository _roleRepository;
        public RoleAppService(IRoleRepository  roleRepository)
        {
            _roleRepository = roleRepository;
        }
        public Task<RoleDto> Create(CreateRoleDto input)
        {
            throw new NotImplementedException();
        }

        public Task Delete(IEntityDto<int> input)
        {
            throw new NotImplementedException();
        }

        public Task<RoleDto> Get(IEntityDto<int> input)
        {
            throw new NotImplementedException();
        }

        public Task<ListRoleDto> GetAll(PagingCommand input)
        {
            throw new NotImplementedException();
        }

        public Task<RoleDto> Update(RoleDto input)
        {
            throw new NotImplementedException();
        }
    }
}
