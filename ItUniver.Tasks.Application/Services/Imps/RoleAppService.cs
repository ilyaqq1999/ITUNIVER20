using System.Collections.Generic;

using AutoMapper;

using ItUniver.Application.Services;
using ItUniver.Tasks.Application.Services.Dto;
using ItUniver.Tasks.Repositories;

namespace ItUniver.Tasks.Application.Services.Imps
{
    public class RoleAppService : ApplicationService, IRoleAppService
    {
        private readonly IRoleRepository roleRepository;

        private readonly IMapper mapper;

        public RoleAppService(IRoleRepository roleRepository, IMapper mapper)
        {
            this.mapper = mapper;
            this.roleRepository = roleRepository;
        }

        public ICollection<RoleDto> GetAll()
        {
            var entities = roleRepository.GetAllList();
            return mapper.Map<ICollection<RoleDto>>(entities);
        }
    }
}
