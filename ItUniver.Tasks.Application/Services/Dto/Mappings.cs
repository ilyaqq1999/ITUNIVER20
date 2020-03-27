using AutoMapper;

using ItUniver.Tasks.Entities;

namespace ItUniver.Tasks.Application.Services.Dto
{
    public class Mappings : Profile
    {
        public Mappings()
        {
            CreateMap<TaskBase, TaskDto>();
            CreateMap<CreateTaskDto, TaskBase>().ForMember(dest => dest.Executor, opt => opt.Ignore());
            CreateMap<UpdateTaskDto, TaskBase>();
            CreateMap<CreateUserDto, User>();
            CreateMap<User, UserDto>();
            CreateMap<Role, RoleDto>();
        }
    }
}
