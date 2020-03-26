using System.Collections.Generic;

using ItUniver.Application.Services;
using ItUniver.Tasks.Application.Services.Dto;

namespace ItUniver.Tasks.Application.Services
{
    public interface IRoleAppService : IApplicationService
    {
        ICollection<RoleDto> GetAll();
    }
}
